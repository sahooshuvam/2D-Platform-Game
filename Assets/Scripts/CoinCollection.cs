using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    ScoreManager score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            score = GetComponent<ScoreManager>();
            score.ScoreCalculator(10);
        }
        
    }
}
