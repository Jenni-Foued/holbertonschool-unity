using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

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
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // Load the Scene Options when the Options button is pressed from the main menu
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
