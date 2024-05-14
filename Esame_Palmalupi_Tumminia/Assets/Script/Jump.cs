using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jump;
    Rigidbody rb;
    public bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        canJump = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rb.AddForce(new Vector3(0.0f, jump, 0.0f), ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
}
