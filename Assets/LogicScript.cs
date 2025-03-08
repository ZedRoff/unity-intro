using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject startMenuScreen;
    public GameObject player;
    /**
    * 0: start menu
    * 1: game start
    * 2: game over
    */
    public int status;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        status = 0;
        scoreText.text = score.ToString();
        StartGameMenu();
    }
    public int GetStatus()
    {
        return status;
        
    }
    public void SetStatus(int value)
    {
        status = value;
    } 
 
    public void AddScore(int value)
    {

        score += value;
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
    }
    public void StartGame()
    {
        status = 1;
        player.SetActive(true);
        startMenuScreen.SetActive(false);
        
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void StartGameMenu()
    {
        startMenuScreen.SetActive(true);
        player.SetActive(false);
    }
}
