using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePistol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime); //rotates 50 degrees per second around z axis
        //Rotation of gun in top right corner
        //Since the guns scale wasn't cooperating, I had to make a completely new script for its rotation
    }
}
