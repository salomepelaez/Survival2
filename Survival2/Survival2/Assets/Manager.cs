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
            thePeople.AddComponent<Rigidbody>();
            thePeople.GetComponent<Rigidbody>().freezeRotation = true;

            int change = Random.Range(0, 2);
            if (j == 0)
            {
                thePeople.AddComponent<Hero>();
                thePeople.GetComponent<Renderer>().material.color = Color.black;
            }

            else
            {
                switch (change)
                {
                    case 0:
                        thePeople.AddComponent<Zombie>();
                        break;
                    case 1:
                        thePeople.AddComponent<Villagers>();
                        break;
                }
            }
        } 

        
                
        
      
    }
}

        

    