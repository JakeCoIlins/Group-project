using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationManagement : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
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
    }
}

