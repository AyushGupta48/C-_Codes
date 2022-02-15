using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RanTerror : MonoBehaviour
{
    public Animator animbullet2; //Bullet movement 
    public Animator animbullet3;
    public Animator animbullet4;
    public Animator animbullet5;
    public Animator animbullet6;
    public Animator animbullet7;
    public Animator animbullet8;
    public Animator animbullet9;
    

    

    
   
    void Update()
    {
        if (Random.Range(1, 225) == 1)
        {
            animbullet2.SetTrigger("BulletShot2"); //Triggers the bullet movement
            
        }

        if (Random.Range(1, 225) == 1)
        {
            animbullet3.SetTrigger("BulletShot3"); //Triggers the bullet movement
           
            
        }

        if (Random.Range(1, 225) == 1)
        {
            animbullet4.SetTrigger("BulletShot4"); //Triggers the bullet movement 
            
        }

        if (Random.Range(1, 225) == 1)
        {
            animbullet5.SetTrigger("BulletShot5"); //Triggers the bullet movement
            
        }

        if (Random.Range(1, 225) == 1)
        {
            animbullet6.SetTrigger("BulletShot6"); //Triggers the bullet movement 
            
        }


        if (Random.Range(1, 225) == 1)
        {
            animbullet7.SetTrigger("BulletShot7"); //Triggers the bullet movement 
            
        }

        if (Random.Range(1, 225) == 1)
        {
            animbullet8.SetTrigger("BulletShot8"); //Triggers the bullet movement 
            
        }

        if (Random.Range(1, 225) == 1)
        {
            animbullet9.SetTrigger("BulletShot9"); //Triggers the bullet movement 
            
        }

       
    }

  
}
