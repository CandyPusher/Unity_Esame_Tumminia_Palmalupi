using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsaContinua : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    Vector3 player;
    float check;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        player.z += speed;
        transform.position = player;

        check = player.x;

        if (Input.GetKey("d"))
        {
            player.x += speed;
        }

        if (Input.GetKey("a"))
        {
            player.x += -speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            player.x = check;
        }
    }
}
