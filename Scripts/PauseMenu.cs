using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject crosshair;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //Pauses game when player presses "Escape"
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); //Gets rid of pausemenu screen
        Time.timeScale = 1f; //Game resumes
        GameIsPaused = false; //Game resumes
        crosshair.SetActive(true); //Crosshair is back active
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); //Pause menu is shown
        Time.timeScale = 0f; //Game is paused
        GameIsPaused = true; //Game is paused
        crosshair.SetActive(false); //Cursor is available and crosshair is gone
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Coding Menu");
    }
}

