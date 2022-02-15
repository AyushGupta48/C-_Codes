using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAudio : MonoBehaviour
{
    AudioSource GunAS; //Gun AudioSource
    public AudioClip ShootAC; //Shoot AudioClip
    
    void Start()
    {
        GunAS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //When mouses is clicked the sound is played
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GunAS.PlayOneShot(ShootAC);
    }
}
