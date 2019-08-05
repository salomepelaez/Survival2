using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public GameObject camara; //Se creó un GameObject público, de esta manera podremos acceder a él desde el inspector, y agregar la cámara principal.
    public float speed = 0.1f; // La velocidad se asignó como un flotante.

    void Update()
    {
        /* El siguiente bloque de código, es el encargado de obtener de obtener las teclas que el jugador presiona, 
        y transformar la ubicación dependiendo de la dirección que se le haya asignado*/
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed; // A la tecla W se le asignó la dirección que mueve hacia adelante.
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed; /* Puesto que no hay una opción que devuelva, es necesario utilizar 
            el transform.foward pero con un signo negativo, el cual se encarga de enviar en la dirección contraria*/
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed; // La tecla D, permite el movimiento hacia la derecha.
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed; /* Como sucede con la tecla S, no hay una opción que permita ir hacia la izquierda, por lo que es necesario
            utilizar un signo negativo para ir hacia la dirección contraria*/
        }

        float rotat = camara.transform.eulerAngles.y; // La rotación se asignó como un flotante, y es la que permite transformar la mira de la cámara.
        transform.rotation = Quaternion.Euler(0.0f, rotat, 0.0f); // Puesto que la rotación fue asignada en Y, es necesario asignarle el float a los parámetros.

    }
}
