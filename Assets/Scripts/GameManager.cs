using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;
    int score = 0;
    public Text scoreText;
    public GameObject gameOverPanel;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().StopSpawing();
        gameOverPanel.SetActive(true);
    }

    public void IncerementScore()
    {
        if (!gameOver)
        {
            score++;
            print(score);

            scoreText.text = score.ToString();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");

    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }


}
