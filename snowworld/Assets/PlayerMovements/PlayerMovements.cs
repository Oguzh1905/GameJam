using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed = 6;
    public Transform groundcheck;
    public float GroundCheckRadius;
    public LayerMask groundlayer;
    private bool isTouchingGround;
    // Start is called before the first frame update
   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundcheck.position, GroundCheckRadius, groundlayer);

        float dirX = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(dirX * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rb.velocity = new Vector2(rb.velocity.x,13);
        }
        
    }
}
