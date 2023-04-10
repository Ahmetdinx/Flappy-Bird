using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;
    int score;

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

        highScoreText.text = "High Score :" + PlayerPrefs.GetInt("HighScore");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
