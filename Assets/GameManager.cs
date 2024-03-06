using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Ball;
    public GameObject Player1;
    public GameObject Player1Goal;
    public GameObject Player2Goal;
    public GameObject Player2;
    public GameObject p1Text;
    public GameObject p2Text;
    private int P1Score;
    private int P2Score;
    

    public void Player1score()
    {
        P1Score++;
        p1Text.GetComponent<TextMeshProUGUI>().text = P1Score.ToString();
        ResetAll();
    }

    public void Player2Score()
    {
        P2Score++;
        p2Text.GetComponent<TextMeshProUGUI>().text = P2Score.ToString();
        ResetAll();
    } 

    //Method to deal with reseting everything

    public void ResetAll()
    {
        Ball.GetComponent<Ball>().ResetBall();
        Player1.GetComponent<Movement>().ResetPaddle();
        Player2.GetComponent<Movement>().ResetPaddle();
    }
}
