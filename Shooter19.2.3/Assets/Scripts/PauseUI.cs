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
    void Resume()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
            
    }
}
