using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class WalkMechanics : MonoBehaviour {
    public float maxSpeed = 5;
    public float acceleration = 3;
    public bool walkEnabled = true;
    float hInput;
    Rigidbody2D rigid;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (walkEnabled)
        {
            updateMovementSpeed();
            updateDirection();
        }
    }

    void updateDirection()
    {
        if (hInput < -0.001f)
        {
            transform.localScale = new Vector3 (-1, 1, 1);
        }
        else if (hInput > .001f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void updateMovementSpeed()
    {
        Vector2 goalVec = new Vector2(maxSpeed * hInput, rigid.velocity.y);
        rigid.velocity = Vector2.Lerp(rigid.velocity, goalVec, acceleration * Time.deltaTime);

    }
    
    public void moveHorizontal(float hInput)
    {
        this.hInput = hInput;
    }

    //Returns the horizontal input that was entered by the player
    public float getHInput()
    {
        return hInput;
    }


}
