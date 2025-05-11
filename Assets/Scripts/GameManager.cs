using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
