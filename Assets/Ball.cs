using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float initalSpeed = 25f; //How fast the ball will move
    public float maxSpeed = 30f;
    public float currentSpeed;
    public Rigidbody2D rb;
    public float maxAngle = 0.67f;
    [SerializeField] Audio audiomanager;
    
    // Start is called before the first frame update
    public Vector3 starPos;
    void Start()
    {
        currentSpeed = initalSpeed;
        launchDirection(); //Call the method so when the game starts the ball is launched in a random direction
        starPos = transform.position;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Need method so the ball can launch is a random direction
    void launchDirection()
    {
        Vector2 direction = Vector2.left; //InsideUnityCircle returns a random point in a sphere - Do not use InsideUnitCircle - not accurate to pong
        if(Random.value < 0.67f)
        {
            direction = Vector2.right;
        }
        direction.y = Random.Range(-maxAngle, maxAngle);
        rb.velocity = direction * initalSpeed; //sets the velocity for the ball
      
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        StartCoroutine(BallTimer());
        transform.position = starPos;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<TrailRenderer>().enabled = false;
        currentSpeed = initalSpeed;
    }


    public IEnumerator BallTimer()
    {
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<TrailRenderer>().enabled = true;
        launchDirection();
    }

    //Use onCollisionEnter to deal with the ball bouncing back at a random angle
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Paddle"))
        {
            if(currentSpeed < maxSpeed)
            {
                currentSpeed += 1f;
            }
             audiomanager.AudioPong();
            // float testAngle = Random.Range(-angle, angle);
            // Vector2 testDire = Quaternion.Euler(0f,0f,testAngle) * Vector2.right;


            rb.velocity = rb.velocity.normalized * currentSpeed;

        } 

    }
}
