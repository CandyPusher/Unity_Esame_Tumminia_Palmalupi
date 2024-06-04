using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    bool isTaken;
    public GameObject player;
    public float counter;
    // Start is called before the first frame update
    void Start()
    {
        isTaken = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0f, 0f, 90f) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && isTaken == false)
        {
            isTaken = true;
            counter++;
            gameObject.SetActive(false);
        }
    }
}
