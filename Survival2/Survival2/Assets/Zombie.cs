using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public void Start()
    {
        int color = Random.Range(0, 3);

        switch (color)
        {
            case 0:
                GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 1:
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }
        
        transform.tag = "Zombie";
    }

    public MyTaste taste;
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

public enum MyTaste
{
    Cerebros,
    Corazones,
    Ojos,
    Orejas,
    Bocas
}

public enum Move
{
    Idle,
    Moving
}

public struct ZombieData
{
    public MyTaste mT;
    public Move mM;
}










