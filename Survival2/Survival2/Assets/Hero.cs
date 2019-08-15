using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    HeroSpeed hs;
    GameObject pov;
   
    void Start()
    {       
        Vector3 posicion = new Vector3();
        posicion.x = Random.Range(-30, 30);
        posicion.z = Random.Range(-30, 30);

        GameObject pov = new GameObject();
        pov.AddComponent<Camera>();        
        pov.AddComponent<HeroAim>();
        gameObject.AddComponent<HeroMove>();
        gameObject.GetComponent<HeroMove>().speed = hs.RandomSpeed();

        pov.transform.SetParent(this.transform);
        pov.transform.localPosition = Vector3.zero;
               
    }

    public void Update()
    {
        float rotat = transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0.0f, rotat, 0.0f);

    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Villager")
        {

            collision.transform.GetComponent<Villagers>().PrintNames();
        }

        if (collision.transform.tag == "Zombie")
        {
            collision.transform.GetComponent<Zombie>().PrintMessages();
           
        }
    }

    
    
}

public struct HeroSpeed
{   

    public Speed mySpeed;
    public float theSpeed;

    public float RandomSpeed()
    {
       
        int x = Random.Range(0, 3);

        switch (x)
        {
            case 0:
                mySpeed = Speed.Low;
                break;

            case 1:
                mySpeed = Speed.Medium;
                break;

            case 2:
                mySpeed = Speed.Fast;
                break;
        }
            
        if (mySpeed == Speed.Low)
        {
            theSpeed = 0.05f;
            Debug.Log("Leeeento");
        }

        else if (mySpeed == Speed.Medium)
        {
            theSpeed = 0.1f;
            Debug.Log("Normalito");
        }

        else if (mySpeed == Speed.Fast)
        {
            theSpeed = 0.2f;
            Debug.Log("Woody y Buzz se acercan a toda velocidad");
        }
        return theSpeed;
    }
    

}

public enum Speed
{
    Low,
    Medium,
    Fast
}


