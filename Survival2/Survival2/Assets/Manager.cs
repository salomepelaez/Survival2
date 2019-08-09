using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{    
    void Start()
    {     
         int x = Random.Range(10, 21);

        for (int j = 0; j < x; j++)
        {
            GameObject thePeople = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 posicion = new Vector3();
            posicion.x = Random.Range(-30, 30);
            posicion.z = Random.Range(-30, 30);
            thePeople.transform.position = posicion;

            int change = Random.Range(0, 2);

            switch (change)
            {
                case 0:
                    thePeople.AddComponent<Zombie>();
                    thePeople.GetComponent<Zombie>();
                    break;
                case 1:
                    thePeople.AddComponent<Villagers>();
                    thePeople.GetComponent<Villagers>();
                    break; 
            }    
        } // No sigue el movimiento de la cámara

        GameObject hero = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hero.AddComponent<Hero>();
        hero.AddComponent<Rigidbody>();
        hero.GetComponent<Rigidbody>().freezeRotation = true;
        hero.GetComponent<Renderer>().material.color = Color.black;
        hero.AddComponent<HeroMove>();
    }
}

        

    