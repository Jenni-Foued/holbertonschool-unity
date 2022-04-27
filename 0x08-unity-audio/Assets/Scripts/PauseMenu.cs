using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseCanvas;

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
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
