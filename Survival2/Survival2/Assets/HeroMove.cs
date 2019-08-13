using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public GameObject hA;
    public float speed = 1f; // La velocidad se asignó como un flotante.

    void Update()
    {
        Move();

    }

    private void Move()
    {
        float hAxis = Input.GetAxisRaw("Horizontal") * speed;
        float vAxis = Input.GetAxisRaw("Vertical") * speed;

        transform.Translate(hAxis, 0, vAxis);
        
    }

}

