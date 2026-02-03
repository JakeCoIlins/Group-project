using UnityEngine;

public class DashController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float dashSpeed = 20f;
    public float dashDuration = 0.2f;
    public float dashCooldown = 1f;

    private Vector3 moveDirection;
    private bool isDashing = false;
    private float lastDashTime = -Mathf.Infinity;

    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(moveX, 0, 0).normalized;

        
        if (!isDashing && moveDirection.magnitude > 0)
        {
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }

        
        if (Input.GetKeyDown(KeyCode.LeftShift) && moveDirection.magnitude > 0 && Time.time >= lastDashTime + dashCooldown)
        {
            StartCoroutine(Dash());
            lastDashTime = Time.time;
        }
    }

    private System.Collections.IEnumerator Dash()
    {
        isDashing = true;

        float startTime = Time.time;
        while (Time.time < startTime + dashDuration)
        {
            transform.position += moveDirection * dashSpeed * Time.deltaTime;
            yield return null;
        }

        isDashing = false;
    }
}