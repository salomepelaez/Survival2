using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villagers : MonoBehaviour
{
    void Start()
    {
        transform.name = "Villager";
        GameObject Villager = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Villager.GetComponent<Renderer>().material.color = Color.yellow;
    }

    
}
