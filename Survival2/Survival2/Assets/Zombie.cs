using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{      

    public void Start()
    {               
        int color = Random.Range(0, 3);

        switch (color)
        {
            case 0:
                GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 1:
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }
            

        transform.name = "Zombie";        
    }    
}

public enum MyTaste
{
    Cerebros,
    Corazones,
    Ojos,
    Orejas,
    Bocas
}

public enum Move
{
    Idle,
    Moving
}








