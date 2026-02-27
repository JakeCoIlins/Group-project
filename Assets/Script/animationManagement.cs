using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationManagement : MonoBehaviour
{
    Animator anim;
    CharacterController characterController;
    void Start()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    public void PlayJumpAnimation()
    {
        anim.Play("Jumping");
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
        }

        if (characterController.isGrounded)
        {
            anim.Play("falling");
        }
    }
}

