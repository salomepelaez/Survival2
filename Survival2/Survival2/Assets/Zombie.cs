using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{           
    public void Start()
    {     
       
        /*
         
         * Este bloque de código se encarga de crear un objeto primitivo, en este caso un cubo.
         * También le asigna una ubicación aleatoria utilizando un random y un Vector3.
         * También le asigna un color aleatorio y un mensaje dependiendo de este.
         
        */

        GameObject zZombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        int color = Random.Range(0, 3);

        switch (color)
        {
            case 0:
                zZombie.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 1:
                zZombie.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 2:
                zZombie.GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }

        
    }

    struct ZombieData
    {
        public enum MyTaste
        {
            Brains,
            Hearts,
            Eyes,
            Ears,
            Mouths
        }

        public enum Move
        {
            Idle,
            Moving
        }
    }
}


