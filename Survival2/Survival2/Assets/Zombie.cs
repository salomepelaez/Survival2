using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    ZombieData zombieData;

    public void Start()
    {    
        zombieData.taste = (MyTaste) Random.Range(0, 5);   
        Coloring(); 
        InvokeRepeating("ZombieMove", 5.0f, 5.0f);
        transform.tag = "Zombie";
    }

    public void Update()
    {
        float zombieSpeed = 0.1f;

        if (move == "Forwards")
        {
            transform.position += transform.forward * zombieSpeed;
        }

        else if(move == "Backwards")
        {
            transform.position -= transform.forward * zombieSpeed;
        }

        else if (move == "Right")
        {
            transform.position += transform.right * zombieSpeed;
        }

        else if (move == "Left")
        {
            transform.position -= transform.right * zombieSpeed;
        }

        else if(move == "Idle")
        {
           //No hace nada, está idle xd ¿qué esperabas?
        }
    }

    public Move zM;
    string move;

    void ZombieMove()
    {
        switch (Random.Range(0, 6)) 
        {
            case 0:

                zM = Move.Moving;
                move = "Forwards";
                break;

            case 1:
                zM = Move.Moving;
                move = "Backwards";
                break;

            case 2:
                zM = Move.Moving;
                move = "Right";
                break;

            case 3:
                zM = Move.Moving;
                move = "Left";
                break;

            case 4:
                zM = Move.Idle;
                move = "Idle";
                break;
        }

        
    }

    public void PrintMessages()
    {        
        Debug.Log("Waaaarr quiero comer " + (zombieData.taste));
    }

    public ZombieColor mC;
   
    public void Coloring()
    {        

        switch(Random.Range(0, 4))
        {
            case 0:
            mC = ZombieColor.Celeste;
            break;

            case 1:
            mC = ZombieColor.Lila;
            break;

            case 2:
            mC = ZombieColor.Verde;
            break;
        }

        if(mC == ZombieColor.Celeste)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
             
        else if(mC == ZombieColor.Lila)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }

        else if(mC == ZombieColor.Verde)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }        
    }
}

public struct ZombieData
{
    public Move zM;
    public MyTaste taste;
    public ZombieColor mC;
    public string move;
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

public enum ZombieColor
{
    Celeste,
    Lila,
    Verde
}











