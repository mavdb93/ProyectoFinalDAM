using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    int score = 0;
    public Text gameScore;
    public Text finalText;
    public void increment(int points)
    {
        
        score += points;
        gameScore.text = score.ToString();
    }
}
