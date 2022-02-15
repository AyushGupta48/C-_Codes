using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; //Disables default cursor
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Input.mousePosition; //Replaces cursor with crosshair
    }
}
