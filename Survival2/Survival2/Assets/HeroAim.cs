using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAim : MonoBehaviour
{
    public bool InvertedMouse;
    float mouseX;
    float mouseY;
    float sensitivity = 40.0f;


    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        }

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
} //Funciona pero da una vuelta completa xdd
/*
{
    float mouseX;
float mouseY;
float sensitivity = 40.0f;
float xAxisClamp = 0.0f;

void Update()
{
    CameraRot();
}

public void CameraRot()
{
    mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
    mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

    xAxisClamp += mouseY;

    if (xAxisClamp > 90.0f)
    {
        xAxisClamp = 90.0f;
        mouseY = 0.0f;
        ClampXAxis(270.0f);
    }

    else if (xAxisClamp < -90.0f)
    {
        xAxisClamp = -90.0f;
        mouseY = 0.0f;
        ClampXAxis(90.0f);
    }

    transform.Rotate(Vector3.left * mouseY);
    transform.Rotate(Vector3.up * mouseX);


}

void ClampXAxis(float myX)
{
    Vector3 eulerRotation = transform.eulerAngles;
    eulerRotation.x = myX;
    transform.eulerAngles = eulerRotation;

}
}*/