using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnCollisin : MonoBehaviour
{
    public GameObject player;
    Life leggi;
    // Start is called before the first frame update
    void Start()
    {
        leggi = GetComponent<Life>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ostacolo")
        {
            leggi.life -= 1;
        }
    }
}
