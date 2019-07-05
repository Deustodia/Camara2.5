using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*This script was made to mantein the player object always in front of a cam 
*
*Made by Deustodia
*
*Suportt us with a suscription at youtube
*/

public class mov_person : MonoBehaviour
{
    public Transform cam;
    void Update()
    {
        transform.LookAt(cam);
    }
}
