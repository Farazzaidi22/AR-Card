using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void AR_Card()
   {
       SceneManager.LoadScene("AR-Card");
   }

   public void RotateCube()
   {
       SceneManager.LoadScene("RotateCube");
   }

   public void Exit()
   {
       Application.Quit();
       Debug.Log("Exited scene");
   }
}
