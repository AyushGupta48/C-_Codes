using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RanTerror2 : MonoBehaviour
{
    public Animator animbullet2; //Variables for bullet movement
    public Animator animbullet3;
    public Animator animbullet4;
    public Animator animbullet5;
    public Animator animbullet6;
    public Animator animbullet7;
    public Animator animbullet8;
    public Animator animbullet9;

    public static float healthAmount = 150; //health
    public GameObject healthDisplay;
    public GameObject crosshair;
    public GameObject GamelostPanel; //losing screen

    void Start()
    {
        healthDisplay.GetComponent<Text>().text = "Health: " + healthAmount;
    }
    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 110) == 1)
        {
            animbullet2.SetTrigger("BulletShot2"); //Triggers the bullet movement 
            if (animbullet2.GetBool("BulletShot2") == true)
            {
                healthAmount -= 10; //if shot decrease health by 10
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            animbullet3.SetTrigger("BulletShot3"); //Triggers the bullet movement 
            if (animbullet3.GetBool("BulletShot3") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            animbullet4.SetTrigger("BulletShot4"); //Triggers the bullet movement 
            if (animbullet4.GetBool("BulletShot4") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            animbullet5.SetTrigger("BulletShot5"); //Triggers the bullet movement 
            if (animbullet5.GetBool("BulletShot5") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            animbullet6.SetTrigger("BulletShot6"); //Triggers the bullet movement 
            if (animbullet6.GetBool("BulletShot6") == true)
            {
                healthAmount -= 10;
            }
        }


        if (Random.Range(1, 110) == 1)
        {
            animbullet7.SetTrigger("BulletShot7"); //Triggers the bullet movement 
            if (animbullet7.GetBool("BulletShot7") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            animbullet8.SetTrigger("BulletShot8"); //Triggers the bullet movement 
            if (animbullet8.GetBool("BulletShot8") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            animbullet9.SetTrigger("BulletShot9"); //Triggers the bullet movement 
            if (animbullet9.GetBool("BulletShot9") == true)
            {
                healthAmount -= 10;
            }

            healthDisplay.GetComponent<Text>().text = "Health: " + healthAmount; //new health shown

            if (healthAmount == 0)
            {
                Time.timeScale = 0;
                GamelostPanel.SetActive(true);
                healthDisplay.SetActive(false);
                Cursor.visible = true;
                crosshair.SetActive(false); //if health is 0 losing screen is displayed
            }
        }
    }
}
