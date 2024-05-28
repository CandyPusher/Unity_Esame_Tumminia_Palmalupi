using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsaContinua : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    Vector3 player;
    public float jump;
    public float jumpNum;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * speed);


        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * speed);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpNum >= 1)
        {
            rb.AddForce(new Vector3(0.0f, jump, 0.0f), ForceMode.Impulse);
            jumpNum = jumpNum - 1f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumpNum = 2;
        }
    }
}
