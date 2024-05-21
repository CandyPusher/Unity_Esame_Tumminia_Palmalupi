using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUi : MonoBehaviour
{
    [SerializeField] private string NewGameLevel = "LV_1";
    public void NewGameButton()
    {
        SceneManager.LoadScene(NewGameLevel);
    }
}
