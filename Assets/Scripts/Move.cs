using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 25.0f;

    private Rigidbody2D rb;

    private SpriteRenderer sr;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");//a¡¢d¡¢¡ú¡¢¡û        
        float moveY = Input.GetAxisRaw("Vertical");

        float x = moveX * speed;
        float y = moveY * speed;
        
        if (moveX < 0)
        {
            animator.SetFloat("Speed", 1.0f);
            sr.flipX = true;
        }
        else if (moveX > 0)
        {
            animator.SetFloat("Speed", 1.0f);
            sr.flipX = false;
        }else
        {
            animator.SetFloat("Speed", 0.0f);
        }
        rb.velocity = new Vector2(x, y);
    }
}
