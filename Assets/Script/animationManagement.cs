using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationManagement : MonoBehaviour
{
    bool isJumping = false;
    bool isHanging = false; 
    Animator anim;
    CharacterController characterController;

    void Start()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    public void PlayJumpAnimation()
    {
        anim.Play("Jump");
    }

    public void PlayLandingAnimation()
    {
        anim.Play("Landing");
    }

    void Update()
    {
        anim.SetFloat("Blend", Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayJumpAnimation();
            isJumping = true;
        }

        if (characterController.isGrounded && isJumping)
        {
            anim.Play("falling");
            isJumping = false;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localScale = new Vector3(1, 1, -1);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        
        if (isHanging)
        {
            anim.Play("Hanging");
        }
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isHanging = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isHanging = false;
        }
    }
}
