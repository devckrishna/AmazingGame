using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float jumpsAllowed;

    private float timesJumped;
    private Rigidbody2D rb;
    private float moveInput;
    private float jumpInput;
    private float previousJumpInput;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        timesJumped=0;
        previousJumpInput=0;
    }

    void FixedUpdate(){
        moveInput=Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(moveInput*speed,rb.velocity.y);

        jumpInput=Input.GetAxis("Vertical");
        if(jumpInput > 0 && timesJumped < jumpsAllowed && previousJumpInput==0){
            rb.velocity=new Vector2(rb.velocity.x,jumpForce);
            timesJumped+=1;
        }
        previousJumpInput=jumpInput;
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground")){
            timesJumped=0;
        }
    }

    void Update()
    {
        
    }
}
