using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*This script was made to control de main camara to orbit around a empty gameobject in the Scene
*
*Made by Deustodia
*
*Suportt us with a suscription at youtube
*/
public class mov_cam : MonoBehaviour
{
    [Range(1f,10f)]
    public float speed;

    void Update(){
      transform.Rotate(0,speed * Time.deltaTime, 0);
    }
}
