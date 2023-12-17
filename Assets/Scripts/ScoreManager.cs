using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCounter;


    // Initialize the score
    void Start()
    {
       scoreCounter=0;
    }


    // Updates the score on the UI
    void Update()
    {
       scoreText.text="Score: " + Mathf.Round(scoreCounter);
    }
}

