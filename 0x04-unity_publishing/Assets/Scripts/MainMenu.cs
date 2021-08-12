using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    // Start the game when Play button is pressed from the main menu
    public void PlayMaze()
    {
        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        SceneManager.LoadScene("Maze");
    }

    // Quit the game when Quit button is pressed from the main menu
    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
