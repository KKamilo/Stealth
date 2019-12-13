using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator animator;

    public float speed;
    float rotar = 2;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
            animator.SetFloat("Vertical", 1);
        }else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
            animator.SetFloat("Vertical", -1);

        }else{
            animator.SetFloat("Vertical", 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Horizontal", 1);

            transform.Rotate(Vector3.up * rotar);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Horizontal", -1);

            transform.Rotate(Vector3.up * -rotar);
        }
        else
        {
            animator.SetFloat("Horizontal", 0);

        }
    }
}
