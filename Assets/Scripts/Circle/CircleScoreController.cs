using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CircleScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int Score = 0;


    public void IncreaseScoreValue(){
        Score++;
        setScoreText();
    }
    private void setScoreText(){
        scoreText.text = Score.ToString();
    }
}
