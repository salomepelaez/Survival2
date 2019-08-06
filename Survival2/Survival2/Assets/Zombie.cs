using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public enum MyTaste
    {
        Brains,
        Hearts,
        Eyes,
        Ears,
        Mouths
    }

    public enum Move
    {
        Idle,
        Moving
    }

    public MyTaste taste1;
    public MyTaste taste2;
    public MyTaste taste3;
    public MyTaste taste4;
    public MyTaste taste5;

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

        int tastes = Random.Range(0, 6);

        switch (tastes)
        {
            case 0:
                taste1 = MyTaste.Brains;
                string cerebros = taste1; //Imprimir el gusto
                break;

            case 1:
                taste2 = MyTaste.Hearts;

                break;

            case 2:
                taste3 = MyTaste.Eyes;
                break;

            case 3:
                taste4 = MyTaste.Ears;
                break;

            case 4:
                taste5 = MyTaste.Mouths;
                break;

        }
        transform.name = "Zombie";

        Debug.Log("Waaaarr quiero comer" + (tastes));
    }

    
}


       
        
        
        
  



