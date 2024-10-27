using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text myScore;
    private int scoreNum;

    void Start()
    {
        scoreNum = 0;
        myScore.text = "Score : " + scoreNum;
    }

    void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.tag == "Coin")
        {
            scoreNum += 100;
           
        }
    }
}
