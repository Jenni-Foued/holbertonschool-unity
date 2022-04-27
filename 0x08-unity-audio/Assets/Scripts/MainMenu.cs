using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Load the scene corresponding to the level number
    public void LevelSelect(int level)
    {
        if (level == 1)
        {
            SceneManager.LoadScene("Level01");
        }
        if (level == 2)
        {
            SceneManager.LoadScene("Level02");
        }
        if (level == 3)
        {
            SceneManager.LoadScene("Level03");
        }
        Time.timeScale = 1f;
    }

    // Exit the game when Exit button is pressed from the main menu
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }

    // Load the Scene Options when the Options button is pressed from the main menu
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
