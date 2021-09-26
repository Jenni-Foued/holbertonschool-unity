using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle invertYAxis;

    private CameraController cameraControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        cameraControllerScript = GameObject.Find("Main Camera").GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // No done yet
    public void Apply()
    {
    }
}
