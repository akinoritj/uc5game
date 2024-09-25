using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public bool isRunning = false;
    public Animator animPlayer;
    public float moveH;
    private Rigidbody2D rb; 
    public int forcaPulo;
    public int velocidade;
    public bool isJumping = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animPlayer = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0 );

        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo, ForceMode2D.Impulse);
            isJumping = true;
        }

        //animação

        if(Input.GetKey(KeyCode.D))
        {
            animPlayer.SetLayerWeight(1, 1);
            spriteRenderer.flipX = false;
            isRunning = true;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            animPlayer.SetLayerWeight(1, 1);
            spriteRenderer.flipX = true;
            isRunning = true;
        }
        else
        {
            animPlayer.SetLayerWeight(1, 0);
        }

        animPlayer.SetBool("isRunning", isRunning);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag ("Chão"))
            {
                isJumping = false;
            }
    }
}
