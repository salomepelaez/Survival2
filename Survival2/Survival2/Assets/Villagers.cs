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

    

    public void PrintNames()
    {
        Names peopleNames = (Names)Random.Range(0, 20);
        Debug.Log("Hola soy " + peopleNames + ". Y tengo " + Random.Range(15, 101) + " años.");
    }

    public enum Names
    {
        Rose,
        Ophelie,
        Celeste,
        Mérida,
        Catrina,
        Dean,
        Will,
        Lucas,
        Dustin,
        Mike,
        Sophie,
        Isabella,
        Amelie,
        Charlotte,
        Milo,
        Dante,
        Ariel,
        Suhail,
        Jake,
        David
    }
}

public struct VillagersData
{
    //public Names peopleNames;
}
