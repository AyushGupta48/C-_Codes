using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class MechClickL2 : MonoBehaviour
{

    public Animator anim; //Calls upon the appropriate animation (in this case dying animation)
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator anim7;
    public Animator anim8;
    public Animator anim9;
    public Animator anim10;

    public GameObject laser; //Variable for the laser attached to the enemy
    public GameObject laser1;
    public GameObject laser2;
    public GameObject laser3;
    public GameObject laser4;
    public GameObject laser5;
    public GameObject laser6;
    public GameObject laser7;
    public GameObject laser8;
    public GameObject laser9;
    public GameObject laser10;

    public GameObject Respawn1; //Variable for respawned Enemies
    public GameObject Respawn2;
    public GameObject Respawn3;
    public GameObject Respawn4;
    public GameObject Respawn5;
    public GameObject Respawn6;
    public GameObject Respawn7;
    public GameObject Respawn8;
    public GameObject crosshair;
    public Camera altcam;

    public GameObject winPanel; //Win screen

    public InputField playername; //Inputted player name
    public GameObject namedisplay;

    private void Start()
    {
        namedisplay.GetComponent<Text>().text = "Player: " + playername.text; //Display player name
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = altcam.ScreenPointToRay(Input.mousePosition); //Raycasts imaginary line from exact mouseposition


            if (Physics.Raycast(ray, out hit))
            {

                BoxCollider bc = hit.collider as BoxCollider;

                if (bc != null && bc.name == "Robot@ShootingL2")
                {

                    Debug.Log("Dead!"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f); //Destroy enemy after 3 seconds, allowing the dying animation to play
                    Destroy(laser); //Destroy laser after 1.5 seconds
                     //Add to score
                    StartCoroutine(your_timer1());

                }

                if (bc != null && bc.name == "Robot@Shooting1L2")
                {

                    Debug.Log("Dead!1"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim1.SetTrigger("ClickRobot1"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser1);
                    
                    StartCoroutine(your_timer2());



                }

                if (bc != null && bc.name == "Robot@Shooting2L2")
                {
                    Debug.Log("Dead!2"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim2.SetTrigger("ClickRobot2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser2);
                    
                    StartCoroutine(your_timer3());


                }

                if (bc != null && bc.name == "Robot@Shooting3L2")
                {
                    Debug.Log("Dead!3"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim3.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser3);
                    
                }

                if (bc != null && bc.name == "Robot@Shooting4L2")
                {
                    Debug.Log("Dead!4"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim4.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser4);
                    
                    StartCoroutine(your_timer4());

                }

                if (bc != null && bc.name == "Robot@Shooting5L2")
                {
                    Debug.Log("Dead!5"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim5.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser5);
                    
                    StartCoroutine(your_timer5());

                }

                if (bc != null && bc.name == "Robot@Shooting6L2")
                {
                    Debug.Log("Dead!6"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim6.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser6);
                    
                    StartCoroutine(your_timer6());


                }

                if (bc != null && bc.name == "Robot@Shooting7L2")
                {
                    Debug.Log("Dead!7"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim7.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser7);
                    
                    StartCoroutine(your_timer7());

                }

                if (bc != null && bc.name == "Robot@Shooting8L2")
                {
                    Debug.Log("Dead!8"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim8.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser8);
                    
                }

                if (bc != null && bc.name == "Robot@Shooting9L2")
                {
                    Debug.Log("Dead!9"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim9.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser9);
                    
                    StartCoroutine(your_timer8());

                }

                if (bc != null && bc.name == "Robot@Shooting10L2")
                {
                    Debug.Log("Dead!10"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim10.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Destroy(laser10);
                    
                }

            }

        }
        //if player kills all enemies...
        if (GameObject.FindWithTag("RobotL2") == null)
        {
            StartCoroutine(Next_Wave());
        }
    }
    //Winning screen is shown. For some reason I could not change the variable from anythging else but "Next_Wave" so i kept it as it is.
    IEnumerator Next_Wave()
   {
        yield return new WaitForSeconds(0.01f);
        winPanel.SetActive(true);
        Cursor.visible = true;
        crosshair.SetActive(false);
   }

    //After reseashing for maybe 1 week straight on how to play the next line of code in Unity after n seconds without the use of a coroutine, I came to no conclusion and solution in doing so
    //Thus, I created several coroutines which many of the robots are linked to which respawn an enemy after 1.2 seconds. Though this is quite tedious...it works!!!
    IEnumerator your_timer1()
    {

        yield return new WaitForSeconds(1.2f);
        Respawn1.SetActive(true); //Spawns another enemy
        laser3.SetActive(true); //Turns on laser object and script for laser of respawned enemy

    }

    IEnumerator your_timer2()
    {

        yield return new WaitForSeconds(1.2f);
        Respawn2.SetActive(true);
        laser4.SetActive(true);

    }

    IEnumerator your_timer3()
    {

        yield return new WaitForSeconds(1.2f);
        Respawn4.SetActive(true);
        laser6.SetActive(true);

    }

    IEnumerator your_timer4()
    {

        yield return new WaitForSeconds(1.2f);

        Respawn3.SetActive(true);
        laser5.SetActive(true);

    }

    IEnumerator your_timer5()
    {

        yield return new WaitForSeconds(1.2f);
        Respawn5.SetActive(true);
        laser7.SetActive(true);

    }

    IEnumerator your_timer6()
    {

        yield return new WaitForSeconds(1.2f);
        Respawn7.SetActive(true);
        laser9.SetActive(true);

    }

    IEnumerator your_timer7()
    {

        yield return new WaitForSeconds(1.2f);
        Respawn6.SetActive(true);
        laser8.SetActive(true);

    }

    IEnumerator your_timer8()
    {

        yield return new WaitForSeconds(1.2f);
        Respawn8.SetActive(true);
        laser10.SetActive(true);

    }
}




