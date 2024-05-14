using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public float jump;
    Rigidbody rb;
    public float jumpNum;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
