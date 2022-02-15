using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads screen
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!"); //When quit is pressed I get a message from Unity so I know the button works
        Application.Quit(); //Closes the program
    }
        
}
