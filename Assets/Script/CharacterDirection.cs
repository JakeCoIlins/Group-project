
using UnityEngine;

public class CharacterDirection : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        spriteRenderer.flipX = true;
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput > 0)
        {
            
            spriteRenderer.flipX = false; 
        }
        else if (moveInput < 0)
        {
           
            spriteRenderer.flipX = true; 
        }
    }
}