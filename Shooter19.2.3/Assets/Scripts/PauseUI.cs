using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject _pauseMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
         
            }
        }
        
    }
    public void Resume()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    public void Pause()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
         
    }
    public void Restart()
    {
        Debug.Log("Restart");
    }
    public void Quit()
    {
        Debug.Log("Quitting");
    }

}