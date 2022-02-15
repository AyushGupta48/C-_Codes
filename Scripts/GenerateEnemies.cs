using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public float xPos;
    public float yPos;
    
    

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    //Randomly generate enemies somewhere on the map
    IEnumerator EnemyDrop()
    {
        
            float xPos = Random.Range(-107.9f, -28f);
            
            Instantiate(theEnemy, new Vector3(xPos, -75, -16), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            
        //THIS DIDNT WORK BUT KEEPING IT HERE FOR REFERENCE
    }
    
}
