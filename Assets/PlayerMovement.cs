using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    CharacterController cc;
    Vector3 moveDirection;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
        cc.SimpleMove(moveDirection);
    }
}