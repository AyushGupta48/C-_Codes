using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0 * Time.deltaTime); //rotates 1 degrees per second around y axis
        //Rotation of gun in top right corner

        if (PauseMenu.GameIsPaused)
        {
            transform.Rotate(0, 0, 0 * Time.deltaTime); //Rotation stops
        }
    }

}