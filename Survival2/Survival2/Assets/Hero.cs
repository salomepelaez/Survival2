using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public GameObject held;

    void Start()
    {
        GameObject s = Instantiate(held, Vector3.zero, Quaternion.identity);
        
        s.GetComponent<Renderer>().material.color = Color.black;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Villager")
        {
            Debug.Log("miau");
        }

        if (collision.transform.name == "Zombie")
        {
            Debug.Log("guau");
        }
    }
}

//Ya no crea el héroe :(
