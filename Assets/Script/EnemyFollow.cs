using UnityEngine;
using UnityEngine.SceneManagement; 

public class EnemyFollow : MonoBehaviour
{
    public Transform player; 
    public float moveSpeed = 5f; 
    public float followDistance = 0.1f; 

    private Rigidbody rb;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player transform not assigned");
        }
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (player == null) return;

        
        Vector3 direction = player.position - transform.position;

        
        if (direction.magnitude > followDistance)
        {
            
            Vector3 moveDirection = direction.normalized;

            
            rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
        }

        
        Rigidbody playerRb = player.GetComponent<Rigidbody>();
        if (playerRb != null)
        {
            float verticalVelocity = playerRb.linearVelocity.y;
            Vector3 currentVelocity = rb.linearVelocity;
            rb.linearVelocity = new Vector3(currentVelocity.x, verticalVelocity, currentVelocity.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}