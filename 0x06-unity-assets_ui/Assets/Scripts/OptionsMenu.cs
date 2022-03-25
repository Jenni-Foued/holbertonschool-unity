using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle invertYAxis;

    // Awake is called before the Start method
    void Awake()
    {
        if (PlayerPrefs.HasKey("InvertYToggle"))
            invertYAxis.isOn = PlayerPrefs.GetInt("InvertYToggle") == 0 ? false : true;
    }

    // Undone work
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Apply button method
    public void Apply()
    {
        if (invertYAxis.isOn)
            PlayerPrefs.SetInt("InvertYToggle", 1);
        else
            PlayerPrefs.SetInt("InvertYToggle", 0);
        Back();
    }
}
