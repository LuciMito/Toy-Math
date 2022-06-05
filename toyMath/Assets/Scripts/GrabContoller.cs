using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabContoller : MonoBehaviour
{

    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;
    private Animator anim;
    public bool pego;

    public static GrabContoller instance;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if(grabCheck.collider != null && grabCheck.collider.tag == "toy16" ||
            grabCheck.collider != null && grabCheck.collider.tag == "toy18" ||
            grabCheck.collider != null && grabCheck.collider.tag == "toy20")
        {
            if (Input.GetKey(KeyCode.P))
            {
                pego = true;
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                anim.SetBool("obj", true);
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
            else
            {
                pego = false;
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                anim.SetBool("obj", false);
            }
        }

    }
}
