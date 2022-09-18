using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game Over Canvas - Used for game
    [Header("Game over UI Object for displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    //score canvas that is used for the game
    [Header("Score UI Object for displaying Score")]
    public GameObject scoreCanvas;
    //Spawner object used for the game
    [Header("Spawner Object for spawning objects in game")]
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        //Speed for game at playing state
        Time.timeScale = 1;
        //Score in visible
        scoreCanvas.SetActive(true);
        //game over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spaner is shown in the game
        spawner.SetActive(true);
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
    public void GameOver()
    {
        //Game Over UI is visible
        gameOverCanvas.SetActive(true);
        //spawner now invisible in the game
        spawner.SetActive(false);
        //speed for the game - at stopping state
        Time.timeScale = 0;
    }
}
