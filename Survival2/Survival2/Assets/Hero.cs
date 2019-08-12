using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    GameObject pov;
   
    void Start()
    {       
        Vector3 posicion = new Vector3();
        posicion.x = Random.Range(-30, 30);
        posicion.z = Random.Range(-30, 30);

        GameObject pov = new GameObject();
        pov.AddComponent<Camera>();        
        pov.AddComponent<HeroAim>();

        pov.transform.SetParent(this.transform);
        pov.transform.localPosition = Vector3.zero;
               
    }

    public void Update()
    {
        float rotat = transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0.0f, rotat, 0.0f);

    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Villager")
        {
           
            Debug.Log("Aldeano");
        }

        if (collision.transform.tag == "Zombie")
        {
            collision.transform.GetComponent<Zombie>().PrintMessages();
           
        }
    }
        
}


