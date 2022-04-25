using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    float startTime;
    [SerializeField] GameObject cam;
    GameObject player;
    [SerializeField]GameObject canvas;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime >= 2)
        {
            playerController.enabled = true;
            cam.SetActive(true);
            canvas.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
