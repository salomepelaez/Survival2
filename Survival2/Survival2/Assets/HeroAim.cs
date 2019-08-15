using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAim : MonoBehaviour
{
    public bool InvertedMouse;
    float mouseX;
    float mouseY;
    float sensitivity = 40.0f;
    float xAxisClamp = 0.0f;

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        xAxisClamp = mouseY;

        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        }

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            
        }

        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
           
        }

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
} 