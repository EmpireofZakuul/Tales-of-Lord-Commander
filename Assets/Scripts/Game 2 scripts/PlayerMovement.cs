using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    private float player;
    public float playerSpeed = 3f;
    public float playerJumpHeight = 5;
    private Rigidbody2D PlayerRigidbody;
    public LayerMask JumpLayer; 
    //public Transform groundCheck;
    bool isGrounded = true;
    public Collider2D playerCollider;
    bool facingRight = true;
    public Animator animator;
    public float runSpeed = 40f;
     public bool moveleft, moveRight;


    float horizontalMove = 0f;




    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
          
    }


    void Update()
    {

        //animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));




        //if (Input.GetKey(KeyCode.A))
        if(moveleft)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
            facingRight = false;

        }
        //if (Input.GetKey(KeyCode.D))
        if(moveRight)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
                
            if (!playerCollider.IsTouchingLayers(JumpLayer))
            {             
                return;              
            }

             PlayerRigidbody.velocity = new Vector2(PlayerRigidbody.velocity.x, playerJumpHeight);
            //PlayerRigidbody.AddForce(new Vector2(0f, playerJumpHeight));
        }
    }

    public void MoveRight(){

       moveRight = true;
    }

    public void MoveLeft(){

        moveleft = true;
   }

   public void Stop(){

        moveleft = false;  
        moveRight = false;
   }

   

}
