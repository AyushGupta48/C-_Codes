﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx;

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFx); //Plays relevant audio when mouse is hovered over button
    }

}
