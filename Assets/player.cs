using UnityEngine;

public class player : MonoBehaviour
{
    private float speed 5.0f;
    private float horizontalInput;
    private float forwardInput
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("vertical");
    }
}
