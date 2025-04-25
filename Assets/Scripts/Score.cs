using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;
    private int score;
    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
    }
    private void Start()
    {
        scoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }
    private void UpdateHighScore() 
    {
        if (score > PlayerPrefs.GetInt("HighScore")) 
        {
            PlayerPrefs.SetInt("HighScore", score);
            bestScoreText.text = score.ToString();
        }
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
        UpdateHighScore();
    }
}
