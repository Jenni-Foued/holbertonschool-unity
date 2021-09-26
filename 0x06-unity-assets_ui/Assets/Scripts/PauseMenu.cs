using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            Resume();
        }
    }

    // Resume the game
    public void Resume()
    {
        pauseCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    // Pause the game
    public void Pause()
    {
        pauseCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    // Restart the game
    public void Restart()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }


    // Load the Main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Load the options scene
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
