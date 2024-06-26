using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * moveSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * moveSpeed);
        }
    }
}
