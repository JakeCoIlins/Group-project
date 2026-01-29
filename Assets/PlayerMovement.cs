
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;

    private CharacterController cc;
    private Vector3 moveDirection;
    private int jumpCount = 0;
    private int maxJumpCount = 2; 

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        moveDirection.x = moveInput * speed;

        
        if (Input.GetButtonDown("Jump") && jumpCount < maxJumpCount)
        {
            moveDirection.y = jumpForce;
            jumpCount++;
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
}