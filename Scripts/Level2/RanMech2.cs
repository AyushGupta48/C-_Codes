using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RanMech2 : MonoBehaviour
{
    public Animator anim; //Variables for robot moving and laser
    public Animator animlaser;
    public Animator anim1;
    public Animator animlaser1;
    public Animator anim2;
    public Animator animlaser2;
    public Animator anim3;
    public Animator animlaser3;
    public Animator anim4;
    public Animator animlaser4;
    public Animator anim5;
    public Animator animlaser5;
    public Animator anim6;
    public Animator animlaser6;
    public Animator anim7;
    public Animator animlaser7;
    public Animator anim8;
    public Animator animlaser8;
    public Animator anim9;
    public Animator animlaser9;
    public Animator anim10;
    public Animator animlaser10;

    public static float healthAmount = 150; //health
    public GameObject healthDisplay;

    public GameObject GamelostPanel; //losing screen

    public GameObject crosshair;
    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 95) == 1)
        {
            anim.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser.SetTrigger("LaserShot"); //Triggers the laser movement with it
            if (animlaser.GetBool("LaserShot") == true)
            {
                healthAmount -= 10; //if shot lose 10 health
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim1.SetTrigger("RanShoot1"); //Triggers the shooting animation 
            animlaser1.SetTrigger("LaserShot1"); //Triggers the laser movement with it
            if (animlaser1.GetBool("LaserShot1") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim2.SetTrigger("RanShoot2"); //Triggers the shooting animation 
            animlaser2.SetTrigger("LaserShot2"); //Triggers the laser movement with it
            if (animlaser2.GetBool("LaserShot2") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim3.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser3.SetTrigger("LaserShot3"); //Triggers the laser movement with it
            if (animlaser3.GetBool("LaserShot3") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim4.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser4.SetTrigger("LaserShot4"); //Triggers the laser movement with it
            if (animlaser4.GetBool("LaserShot4") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim5.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser5.SetTrigger("LaserShot5"); //Triggers the laser movement with it
            if (animlaser5.GetBool("LaserShot5") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim6.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser6.SetTrigger("LaserShot6"); //Triggers the laser movement with it
            if (animlaser6.GetBool("LaserShot6") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim7.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser7.SetTrigger("LaserShot7"); //Triggers the laser movement with it
            if (animlaser7.GetBool("LaserShot7") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim8.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser8.SetTrigger("LaserShot8"); //Triggers the laser movement with it
            if (animlaser8.GetBool("LaserShot8") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim9.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser9.SetTrigger("LaserShot9"); //Triggers the laser movement with it
            if (animlaser9.GetBool("LaserShot9") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 95) == 1)
        {
            anim10.SetTrigger("RanShoot"); //Triggers the shooting animation 
            animlaser10.SetTrigger("LaserShot10"); //Triggers the laser movement with it
            if (animlaser10.GetBool("LaserShot10") == true)
            {
                healthAmount -= 10;
            }
        }

        healthDisplay.GetComponent<Text>().text = "Health: " + healthAmount; //Health displayed depending on how many times shot

        if (healthAmount == 0)
        {
            Time.timeScale = 0;
            GamelostPanel.SetActive(true);
            healthDisplay.SetActive(false);
            Cursor.visible = true;
            crosshair.SetActive(false); //if health is 0 then losing screen is displayed
        }
    }
}
