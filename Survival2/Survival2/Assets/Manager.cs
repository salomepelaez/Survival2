using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    int x = Random.Range(10, 21);
    GameObject[] people;

    void Start()
    {
        Zombie theZombie = new Zombie();

        for (int j = 0; j < x; j++)
        {
            GameObject thePeople = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 posicion = new Vector3();
            posicion.x = Random.Range(-30, 30);
            posicion.z = Random.Range(-30, 30);
            thePeople.transform.position = posicion;

            int change = Random.Range(0, 3);

            switch (change)
            {
                case 0:
                    thePeople.GetComponent<Zombie>();
                    break;
                case 1:
                    thePeople.GetComponent<Renderer>().material.color = Color.cyan;
                    break; 
            }    
        }
    }
}

        

    