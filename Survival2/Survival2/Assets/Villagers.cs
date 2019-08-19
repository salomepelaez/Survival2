using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villagers : MonoBehaviour
{
    public VillagersData villagersData;

    void Start()
    {
        transform.tag = "Villager";
                
        GetComponent<Renderer>().material.color = Color.yellow;

        villagersData.age = Random.Range(15, 101);
        villagersData.peopleNames = (Names)Random.Range(0, 20);
    }

    public void PrintNames()
    {
        Debug.Log("Hola soy " + villagersData.peopleNames + ". Y tengo " + villagersData.age + " años.");
    }
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

public struct VillagersData
{   
    public int age;
    public Names peopleNames;    
}
