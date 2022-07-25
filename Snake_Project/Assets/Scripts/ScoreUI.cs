using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public static int score = 0;
    public string scoreText = "Score";

    public TextMeshProUGUI textScore;
    public static ScoreUI gameScore;

    private void Awake()
    {
        gameScore = this;
    }

    private void Start()
    {
        score = 0;
    }

    void Update()
    {
        if (textScore != null)
        {
            textScore.text = scoreText + score.ToString();
        }
    }
}