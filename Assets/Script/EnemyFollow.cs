using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float followDistance = 0.1f;
    public Transform enemyTransform; // Reference to the enemy's transform for flipping

    private Rigidbody rb;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player transform not assigned");
        }
        rb = GetComponent<Rigidbody>();
        if (enemyTransform == null)
        {
            enemyTransform = this.transform;
        }
    }

    void FixedUpdate()
    {
        if (player == null) return;

        Vector3 direction = player.position - transform.position;

        // Check if player is behind the enemy
        Vector3 enemyForward = enemyTransform.forward;
        float dotProduct = Vector3.Dot(enemyForward, direction.normalized);

        if (dotProduct < 0)
        {
            // Player is behind; turn around
            enemyTransform.Rotate(0, 180f, 0);
        }

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