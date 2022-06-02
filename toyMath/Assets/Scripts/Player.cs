using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed;
    public float JumpForce;
    public bool isJumping;
    private Rigidbody2D rig;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            isJumping = false;
            anim.SetBool("jump", false);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isJumping = true;
        }
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        if(GrabContoller.instance.pego == false)
        {
            if (Input.GetAxis("Horizontal") > 0f)
            {
                anim.SetBool("walk", true);
                anim.SetBool("obj", false);
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }

            if (Input.GetAxis("Horizontal") < 0f)
            {
                anim.SetBool("walk", true);
                anim.SetBool("obj", false);
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }

            if (Input.GetAxis("Horizontal") == 0f)
            {
                anim.SetBool("walk", false);
                anim.SetBool("obj", false);
            }
        }

        else if (GrabContoller.instance.pego == true)
        {
            if (Input.GetAxis("Horizontal") > 0f)
            {
                anim.SetBool("walk", true);
                anim.SetBool("obj", true);
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }

            if (Input.GetAxis("Horizontal") < 0f)
            {
                anim.SetBool("walk", true);
                anim.SetBool("obj", true);
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }

            if (Input.GetAxis("Horizontal") == 0f)
            {
                anim.SetBool("walk", false);
                anim.SetBool("obj", true);
            }
        }

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isJumping == false)
            {
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                anim.SetBool("jump", true);
            }
        }
    }

   public ArrayList JumpTest(string direction, bool isJumping)
    {
        float jumpForce = 20f;
        ArrayList jumpVector = new ArrayList();
        if (direction.Equals("Jump"))
        {
            if (isJumping == false)
            {
                jumpVector.Add(0f);
                jumpVector.Add(jumpForce);
            }
        }
        return jumpVector;
    }

    public ArrayList MoveTest(string direction)
    {
        float velocidade = 8f;
        ArrayList moveVector = new ArrayList();

        if (direction.Equals("Horizontal"))
        {
            moveVector.Add(velocidade);
            moveVector.Add(0f);
            moveVector.Add(0f);
        }
        return moveVector;
    }

}
