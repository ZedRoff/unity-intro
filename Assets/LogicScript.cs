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
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

 
    public void AddScore()
    {

        score += 1;
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
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
