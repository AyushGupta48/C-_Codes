using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RanAlien : MonoBehaviour
{
    public Animator anim; //Variable for the movement of the aliens and the orbs
    public Animator animorb;
    public Animator anim1;
    public Animator animorb1;
    public Animator anim2;
    public Animator animorb2;
    public Animator anim3;
    public Animator animorb3;
    public Animator anim4;
    public Animator animorb4;
    public Animator anim5;
    public Animator animorb5;
    public Animator anim6;
    public Animator animorb6;
    public Animator anim7;
    public Animator animorb7;
    public Animator anim8;
    public Animator animorb8;
    public Animator anim9;
    public Animator animorb9;
    

    
    void Update()
    {
        if (Random.Range(1, 250) == 1)
        {
            anim.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb.SetTrigger("OrbShot"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim1.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb1.SetTrigger("OrbShot1"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim2.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb2.SetTrigger("OrbShot2"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim3.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb3.SetTrigger("OrbShot3"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim4.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb4.SetTrigger("OrbShot4"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim5.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb5.SetTrigger("OrbShot5"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim6.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb6.SetTrigger("OrbShot6"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim7.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb7.SetTrigger("OrbShot7"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim8.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb8.SetTrigger("OrbShot8"); //Triggers the orb movement with it
            
        }

        if (Random.Range(1, 250) == 1)
        {
            anim9.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb9.SetTrigger("OrbShot9"); //Triggers the orb movement with it
            
        }

       

    }
}
