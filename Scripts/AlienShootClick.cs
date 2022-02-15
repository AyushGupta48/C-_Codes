using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienShootClick : MonoBehaviour
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

    public GameObject Orb; //Variable for Orb that is shot at player
    public GameObject Orb1;
    public GameObject Orb2;
    public GameObject Orb3;
    public GameObject Orb4;
    public GameObject Orb5;
    public GameObject Orb6;
    public GameObject Orb7;
    public GameObject Orb8;
    public GameObject Orb9;


    public GameObject Respawn1; //Variable for respawned enemies
    public GameObject Respawn2;
    public GameObject Respawn3;
    public GameObject Respawn4;
    public GameObject Respawn5;
    public GameObject Respawn6;
    public GameObject Respawn7;

    public GameObject NextLevelPanel; //used when player clears level
    public GameObject TextForWave2;
    public GameObject gameL1;
    public GameObject gameL2;

    public InputField playername; //Inputted player name
    public GameObject namedisplay;

    public Camera altcam; //Since we are using a specific camera to that map instead of the main camera, this varaible is needed

    private void Start()
    {
        namedisplay.GetComponent<Text>().text = "Player: " + playername.text; //Player name is shown on screen
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
                if (bc != null && bc.name == "Alien")
                {
                    Debug.Log("Dead!"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f); //Kills the enemy after 3 seconds, allowing animation to complete playing
                    Orb.SetActive(false); //Removed enemy's orb after 1.5 seconds 

                    StartCoroutine(Wait1());

                    
                }

              
                if (bc != null && bc.name == "Alien1")
                {
                    Debug.Log("Dead!1"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim1.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb1.SetActive(false);

                    StartCoroutine(Wait2());

                    
                }

                if (bc != null && bc.name == "Alien2")
                {
                    Debug.Log("Dead!2"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim2.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb2.SetActive(false);

                    StartCoroutine(Wait3());

                }

                if (bc != null && bc.name == "Alien3")
                {
                    Debug.Log("Dead!3"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim3.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb3.SetActive(false);
                    StartCoroutine(Wait4());
                    
                }

                if (bc != null && bc.name == "Alien4")
                {
                    Debug.Log("Dead!4"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim4.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb4.SetActive(false);

                    StartCoroutine(Wait5());

                    
                }

                if (bc != null && bc.name == "Alien5")
                {
                    Debug.Log("Dead!5"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim5.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb5.SetActive(false);
                }

                if (bc != null && bc.name == "Alien6")
                {
                    Debug.Log("Dead!6"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim6.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb6.SetActive(false);

                    StartCoroutine(Wait6());

                }

                if (bc != null && bc.name == "Alien7")
                {
                    Debug.Log("Dead!7"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim7.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb7.SetActive(false);

                    StartCoroutine(Wait7());

                    
                }

                if (bc != null && bc.name == "Alien8")
                {
                    Debug.Log("Dead!8"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim8.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb8.SetActive(false);
                }

                if (bc != null && bc.name == "Alien9")
                {
                    Debug.Log("Dead!9"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim9.SetTrigger("ClickAlien"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    Orb9.SetActive(false);
                }



            }


        }
        //If player has killed all aliens...
        if (GameObject.FindWithTag("Alien") == null)
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
    }
        //After reseashing for maybe 1 week straight on how to play the next line of code in Unity after n seconds without the use of a coroutine, I came to no conclusion and solution in doing so
        //Thus, I created several coroutines which many of the robots are linked to which respawn an enemy after 1.2 seconds. Though this is quite tedious...it works!!!

        IEnumerator Wait1()
    {
        yield return new WaitForSeconds(1.3f);
        Respawn1.SetActive(true);
        Orb3.SetActive(true);
    }

    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(1.3f);
        Respawn6.SetActive(true);
        Orb8.SetActive(true);
    }

    IEnumerator Wait3()
    {
        yield return new WaitForSeconds(1.3f);

        Respawn2.SetActive(true);
        Orb4.SetActive(true);
    }

    IEnumerator Wait4()
    {
        yield return new WaitForSeconds(1.3f);
        Respawn4.SetActive(true);
        Orb6.SetActive(true);
    }

    IEnumerator Wait5()
    {
        yield return new WaitForSeconds(1.3f);
        Respawn3.SetActive(true);
        Orb5.SetActive(true);
    }

    IEnumerator Wait6()
    {
        yield return new WaitForSeconds(1.3f);

        Respawn5.SetActive(true);
        Orb7.SetActive(true);
    }

    IEnumerator Wait7()
    {
        yield return new WaitForSeconds(1.3f);
        Respawn7.SetActive(true);
        Orb9.SetActive(true);
    }
}
