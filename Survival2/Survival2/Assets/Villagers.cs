using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villagers : MonoBehaviour
{
    void Start()
    {
        transform.tag = "Villager";
                
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    
}
