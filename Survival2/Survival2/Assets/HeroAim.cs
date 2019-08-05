using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAim : MonoBehaviour
{
    // Se crearon dos variables de tipo flotante, que almacenan la ubicación en X y Y del mouse.
    float mouseX;
    float mouseY;
    public bool InvertedMouse; //El booleano Inverted Mouse, será el que en el siguiente bloque de código invierta la dirección del mouse.

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X"); // Con el Input, obtenemos la ubicación en X del mouse.

        if (InvertedMouse) // Al utlizar un If, con el booleano Inverted Mouse, podemos obtener la ubicación del mouse en el eje Y, tanto en dirección posotiva como negativa.
        {
            mouseY += Input.GetAxis("Mouse Y"); // Con el Input de MouseY, obtenemos la ubicación en el eje Y del mouse, pero de dirección positiva. 
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y"); // Al haber utilizado el Inverted Mouse, podemos averiguar la posición del mouse en Y, pero en dirección negativa.
        }

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0); // Se creó un Vector3, que almacena el eje X y Y de la cámara.

    }
}
