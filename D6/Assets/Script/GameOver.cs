using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject overMenu;

    // Start is called before the first frame update
    void Start()
    {
        overMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void GameIsOver()
    {
        overMenu.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = true;
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }
}
