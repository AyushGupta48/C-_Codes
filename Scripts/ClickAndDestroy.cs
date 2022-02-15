using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class ClickAndDestroy : MonoBehaviour
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

    public GameObject NextLevelPanel; //When player clears level
    public GameObject TextForWave2;
    public GameObject gameL1;
    public GameObject gameL2;

    public InputField playername; //Inputted player name
    public GameObject namedisplay;

    private void Start()
    {
        namedisplay.GetComponent<Text>().text = "Player: " + playername.text; //Inputted player name displayed on screen
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Raycasts imaginary line from exact mouseposition


            if (Physics.Raycast(ray, out hit))
            {

                BoxCollider bc = hit.collider as BoxCollider;

                if (bc != null && bc.name == "Robot@Shooting")
                {
                    
                    Debug.Log("Dead!"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f); //Destroy enemy after 3 seconds, allowing the dying animation to play
                    laser.SetActive(false); //Hides laser after 1.5 seconds
                    ScoreScript.scoreValue += 10; //Add to score
                    StartCoroutine(your_timer1());

                }

                if (bc != null && bc.name == "Robot@Shooting1")
                {

                    Debug.Log("Dead!1"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim1.SetTrigger("ClickRobot1"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser1.SetActive(false);
                    ScoreScript.scoreValue += 10;
                    StartCoroutine(your_timer2());

                   

                }

                if (bc != null && bc.name == "Robot@Shooting2")
                {
                    Debug.Log("Dead!2"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim2.SetTrigger("ClickRobot2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser2.SetActive(false) ;
                    ScoreScript.scoreValue += 10;
                    StartCoroutine(your_timer3());

                    
                }

                if (bc != null && bc.name == "Robot@Shooting3")
                {
                    Debug.Log("Dead!3"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim3.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser3.SetActive(false);
                    ScoreScript.scoreValue += 10;
                }

                if (bc != null && bc.name == "Robot@Shooting4")
                {
                    Debug.Log("Dead!4"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim4.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser4.SetActive(false);
                    ScoreScript.scoreValue += 10;
                    StartCoroutine(your_timer4());

                }

                if (bc != null && bc.name == "Robot@Shooting5")
                {
                    Debug.Log("Dead!5"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim5.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser5.SetActive(false);
                    ScoreScript.scoreValue += 10;
                    StartCoroutine(your_timer5());
                    
                }

                if (bc != null && bc.name == "Robot@Shooting6")
                {
                    Debug.Log("Dead!6"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim6.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser6.SetActive(false);
                    ScoreScript.scoreValue += 10;
                    StartCoroutine(your_timer6());

                    
                }

                if (bc != null && bc.name == "Robot@Shooting7")
                {
                    Debug.Log("Dead!7"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim7.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser7.SetActive(false);
                    ScoreScript.scoreValue += 10;
                    StartCoroutine(your_timer7());
                   
                }

                if (bc != null && bc.name == "Robot@Shooting8")
                {
                    Debug.Log("Dead!8"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim8.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser8.SetActive(false);
                    ScoreScript.scoreValue += 10;
                }

                if (bc != null && bc.name == "Robot@Shooting9")
                {
                    Debug.Log("Dead!9"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim9.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser9.SetActive(false);
                    ScoreScript.scoreValue += 10;
                    StartCoroutine(your_timer8());
                    
                }

                if (bc != null && bc.name == "Robot@Shooting10")
                {
                    Debug.Log("Dead!10"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim10.SetTrigger("ClickRobot"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    laser10.SetActive(false);
                    ScoreScript.scoreValue += 10;
                }

            }

        }
        //If enemy has killed all enemies...
      if (GameObject.FindWithTag("Enemy") == null)
      {
          StartCoroutine(Next_Wave());
      }
    }

    //Starting next level
    IEnumerator Next_Wave()
    {
        NextLevelPanel.SetActive(true);
        TextForWave2.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        gameL1.SetActive(false);
        gameL2.SetActive(true);
        laser1.SetActive(true);
        laser.SetActive(true);
        laser2.SetActive(true);
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


    

