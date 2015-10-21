using UnityEngine;
using System.Collections;

public class JumpMechanics : MonoBehaviour {
    public int[] layerCheckInAir; //These are the layers that will be checked to see if the player is in air or not
    public float jumpForce = 5;
    public float floatyForce;
    Rigidbody2D rigid;
    bool inAir;
    int layerMask;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        foreach (int lMask in layerCheckInAir)
        {
            layerMask += 1 << lMask;
        }
    }

    void Update()
    {
        inAir = checkInAir();
        applyFloatyForce();
    }

    void applyFloatyForce()
    {
        if (rigid.velocity.y < -0.01f)
        {
            rigid.AddForce(Vector2.up * floatyForce * Time.deltaTime);
        }
    }

    public void jump(bool jumpInput)
    {
        if (jumpInput)
        {
            
            if (inAir)
            {
               calculateJump();
            }
        }
    }

    void calculateJump()
    {
        rigid.AddForce(Vector2.up * jumpForce * 1000);
    }

    bool checkInAir()
    {
        //RaycastHit2D hit;
        if (Physics2D.Raycast(transform.position, -transform.up, .1f, layerMask))
        {
            return true;

        }
        return false;
    }

    public bool getInAir()
    {
        return inAir;
    }

}
