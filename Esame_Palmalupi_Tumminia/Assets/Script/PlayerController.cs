using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * speed);
        }
    }
}
