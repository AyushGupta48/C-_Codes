using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayStart : MonoBehaviour
{
    public GameObject countDown;
    public GameObject screen;
    public GameObject health;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartDelay());
    }


    IEnumerator StartDelay()
    {
        health.SetActive(false);
        Time.timeScale = 0; //Game is paused
        float pauseTime = Time.realtimeSinceStartup + 3f; //Allows 3 secods for game to start
        while (Time.realtimeSinceStartup < pauseTime) //While the time is still less than 3 seconds, the game remains paused
            yield return 0;
        countDown.gameObject.SetActive(false); //After 3 secs the countdown is removed
        screen.gameObject.SetActive(false); //This was implemented into the code so players don't have the ability to simply shoot the enemies before game starts
        health.SetActive(true);
        Time.timeScale = 1; //Resume game
    }
}
