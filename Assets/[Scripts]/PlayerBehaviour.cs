using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    public float groundCheckRadius = 0.15f;
    public Transform groundCheckPos;
    public LayerMask whatIsGround;
    private bool isGrounded = true;
    [SerializeField]
    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Run();
        Jump();
        duck();
    }

    public void Run()
    {
        float x = Input.GetAxis("Horizontal");

        if (x != 0)
        {
            Flip(x);
            Vector2 movement = new Vector2(x, 0);
            transform.Translate(speed * Time.deltaTime * movement);
            isGrounded = GroundCheck();
            anim.SetBool("isSkipping", true);

        }
        if ((isGrounded) && (x == 0))
        {
            anim.SetBool("isSkipping", false);
        }


        //transform.Translate(Vector2.right * Time.deltaTime * speed);
        isGrounded = GroundCheck();
    } 

    public void Jump()
    {
        if (isGrounded && Input.GetAxis("Jump") > 0)
        {
            anim.SetBool("isJumping", true);
            rb.AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);
            isGrounded = false;
        }
        else
        {
            anim.SetBool("isJumping", false);
            isGrounded = true;
        }
    }

    private bool GroundCheck()
    {

        return Physics2D.OverlapCircle(groundCheckPos.position, groundCheckRadius, whatIsGround);

    }
    public void Flip(float x)
    {
        if (x != 0.0f)
        {
            transform.localScale = new Vector3((x > 0.0f) ? 1.0f : -1.0f, 1.0f, 1.0f);
        }

    }

    public void duck()
    {
        if (isGrounded && Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isDucking", true);
            isGrounded = true;
        }
        else
        {
            anim.SetBool("isDucking", false);
        }
    }
}