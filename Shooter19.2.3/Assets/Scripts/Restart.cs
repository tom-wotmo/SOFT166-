using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
  public void RestartGame()
    {
        //using the scene manager it reloads the active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
