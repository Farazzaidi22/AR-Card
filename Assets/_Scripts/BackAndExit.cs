using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackAndExit : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited Scene");
    }
   
}
