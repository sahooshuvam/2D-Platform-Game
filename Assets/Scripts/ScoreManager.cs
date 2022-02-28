using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public void ScoreCalculator(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log("Score: " +score);
    }
}
