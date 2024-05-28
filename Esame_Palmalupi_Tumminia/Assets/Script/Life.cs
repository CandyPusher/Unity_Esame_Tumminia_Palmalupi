using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    [SerializeField] private string NewGamingLevel = "MN_Death";
    public float life;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(life == 0)
        {
            SceneManager.LoadScene(NewGamingLevel);
        }    
    }
}
