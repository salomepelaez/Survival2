using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public HeroAim hA;
    public float speed = 10.0f; // la cámara se va sola xd

    void Update()
    {
        Move();

    }

    private void Move()
    {
        float hAxis = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float vAxis = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.Translate(hAxis, 0, vAxis);
        
    }

}

