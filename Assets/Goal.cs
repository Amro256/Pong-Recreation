using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    public bool checkPlayer1Goal;
    
    private void OnTriggerEnter2D(Collider2D collision) //Checks if the balls collides with the goals areas
    { 
       if(collision.gameObject.CompareTag("Ball")) 
       {
            if(checkPlayer1Goal)
            {
                //Player 2 scored 
                Debug.Log("p2Test");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Score();
                
            }
            else
            {
                Debug.Log("p1Test");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1score();
                // PLayer 1 scored
            }
       }
       
       
    }

}
