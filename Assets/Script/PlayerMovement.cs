
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    public float wallJumpForceX = 5f;
    public float wallJumpForceY = 8f;
    public float wallDetectionDistance = 0.5f;
    public float wallJumpSlowFactor = 0.5f; 

    private CharacterController cc;
    private Vector3 moveDirection;
    private int jumpCount = 0;
    private int maxJumpCount = 2;
    private bool isTouchingWall = false;
    private Vector3 wallNormal;

    private bool isWallJumping = false;
    private float wallJumpTimer = 0f;
    public float wallJumpDuration = 0.5f; 

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        // Reduce speed if wall jumping
        float currentSpeed = speed;
        if (isWallJumping)
        {
            currentSpeed *= wallJumpSlowFactor;
            wallJumpTimer += Time.deltaTime;
            if (wallJumpTimer >= wallJumpDuration)
            {
                isWallJumping = false;
                wallJumpTimer = 0f;
            }
        }

        moveDirection.x = moveInput * currentSpeed;

        DetectWall();

        if (Input.GetButtonDown("Jump"))
        {
            if (cc.isGrounded || isTouchingWall || jumpCount < maxJumpCount)
            {
                if (isTouchingWall)
                {
                    moveDirection.y = wallJumpForceY;
                    moveDirection.x = wallNormal.x * wallJumpForceX;

                    isWallJumping = true; 
                    wallJumpTimer = 0f;
                }
                else
                {
                    moveDirection.y = jumpForce;
                }
                jumpCount++;
            }
        }

        if (cc.isGrounded && moveDirection.y <= 0)
        {
            moveDirection.y = 0f;
            jumpCount = 0;
        }
        else
        {
            moveDirection.y += gravity * Time.deltaTime;
        }

        cc.Move(moveDirection * Time.deltaTime);
    }

    void DetectWall()
    {
        isTouchingWall = false;
        wallNormal = Vector3.zero;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.right, out hit, wallDetectionDistance))
        {
            if (!hit.collider.CompareTag("Player"))
            {
                isTouchingWall = true;
                wallNormal = hit.normal;
            }
        }
        else if (Physics.Raycast(transform.position, Vector3.left, out hit, wallDetectionDistance))
        {
            if (!hit.collider.CompareTag("Player"))
            {
                isTouchingWall = true;
                wallNormal = hit.normal;
            }
        }
    }
}