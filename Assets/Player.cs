using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float rotar=2;
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * speed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= transform.forward * speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up*rotar);
            }
            if (Input.GetKey(KeyCode.A))
            {
               transform.Rotate(Vector3.up*-rotar);
            } 
    }
}
