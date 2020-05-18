using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Implementing game over canvas
    public GameObject gameOverCanvas;
    //Implementing score canvas
    public GameObject scoreCanvas;
   
    void Start()
    {
        //set visible the score canvas
        scoreCanvas.SetActive(true);
        //set invisible the game over canvas
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
   public void GameOver()
   {
       //set visible the game over canvas
       gameOverCanvas.SetActive(true);
       //set invisible the score canvas
       scoreCanvas.SetActive(false);
       //stoping the game
       Time.timeScale = 0;
   }

   public void Replay()
   {
       //reloading the scene to replay the game
       SceneManager.LoadScene(0);
   }
}
