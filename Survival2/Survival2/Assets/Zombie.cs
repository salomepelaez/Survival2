﻿using System.Collections;
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
        InvokeRepeating("ZombieMove", 5.0f, 5.0f);
        transform.tag = "Zombie";
    }

    public Move zM;
    string move;

    void ZombieMove()
    {
        int pst = Random.Range(0, 6);
        
        switch (pst)
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

    public MyTaste taste;
    public void PrintMessages()
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











