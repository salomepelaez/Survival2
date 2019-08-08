using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    GameObject pov;

    void Start()
    {
        GameObject s = GameObject.CreatePrimitive(PrimitiveType.Cube);
        s.AddComponent<Rigidbody>();
        s.GetComponent<Rigidbody>().freezeRotation = true;
        s.GetComponent<Renderer>().material.color = Color.black;

        Vector3 posicion = new Vector3();
        posicion.x = Random.Range(-30, 30);
        posicion.z = Random.Range(-30, 30);

        GameObject pov = new GameObject();
        s.AddComponent<Camera>();
        s.AddComponent<HeroMove>();
        s.AddComponent<HeroAim>();

        pov.transform.SetParent(this.transform);
        s.transform.localPosition = Vector3.zero;
    }

    public void Update()
    {
        float rotat = transform.eulerAngles.y; 
        transform.rotation = Quaternion.Euler(0.0f, rotat, 0.0f);
                
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Villager")
        {
            Debug.Log("miau");
        }

        if (collision.transform.name == "Zombie")
        {
            Messages();
            Debug.Log("alv");
        }
    }

    public MyTaste taste; //Hasta acá funciona pero el collider nel :(
    public void Messages()
    {
        int tastes = Random.Range(0, 6);

        switch (tastes)
        {
            case 0:
                taste = MyTaste.Cerebros;

                break;

            case 1:
                taste = MyTaste.Corazones;

                break;

            case 2:
                taste = MyTaste.Ojos;
                break;

            case 3:
                taste = MyTaste.Orejas;
                break;

            case 4:
                taste = MyTaste.Bocas;
                break;

        }

        if (taste == MyTaste.Cerebros)
        {
            Debug.Log("Waaaarr quiero comer " + (taste));
        }

        if (taste == MyTaste.Corazones)
        {
            Debug.Log("Waaaarr quiero comer " + (taste));
        }

        if (taste == MyTaste.Ojos)
        {
            Debug.Log("Waaaarr quiero comer " + (taste));
        }

        if (taste == MyTaste.Orejas)
        {
            Debug.Log("Waaaarr quiero comer " + (taste));
        }

        if (taste == MyTaste.Bocas)
        {
            Debug.Log("Waaaarr quiero comer " + (taste));
        }
    }
}


