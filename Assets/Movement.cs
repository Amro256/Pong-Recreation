using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; //Determines how fast the paddles will move 
    float movement; //variable for movement direction 
    public bool CheckPlayer1; //Bool to check if
    [SerializeField] Rigidbody2D rb; //Refernece to the Rigidbody
    private Vector3 startPosition;


    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if(CheckPlayer1) //Checks if we are player one
        {
            movement = Input.GetAxisRaw("Vertical"); //Input for player 1
        }
        else //if not then P2 input
        {
            movement = Input.GetAxisRaw("VerticalP2"); //Input for 2nd player
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed); //Setting the velocity for the RB
        

    }

    public void ResetPaddle()
    {
        transform.position = startPosition;
    }

   

}
