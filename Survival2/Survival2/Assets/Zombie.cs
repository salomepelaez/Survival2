using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{           
    public void Start()
    {  
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

        transform.name = "Zombie";
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


