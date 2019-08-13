using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAim : MonoBehaviour
{
    float mouseX;
	float mouseY;
	float sensitivity = 100.0f;
    void Update()
    {
        CameraRot();

    }

	public void CameraRot()
	{
		 mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
		 mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
		
		transform.Rotate(-transform.right * mouseY);
		
	}
}
