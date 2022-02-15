using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolCursor : MonoBehaviour
{
    public Texture2D cursorArrow;
    void Start()
    {
        // Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware); //Changed the default cursor to the crosshair
    }

    
}
