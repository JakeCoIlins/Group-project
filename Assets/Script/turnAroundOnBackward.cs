using UnityEngine;

public class turnAroundOnBackward : MonoBehaviour
{
    public float turnSpeed = 10f; 

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal < 0)
        {
            
            Quaternion targetRotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
        }
        else if (horizontal > 0)
        {
            
            Quaternion targetRotation = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
        }
    }
}