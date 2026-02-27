using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class animationManagement : MonoBehaviour
{
    bool isJumping = false;
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



    }
}

