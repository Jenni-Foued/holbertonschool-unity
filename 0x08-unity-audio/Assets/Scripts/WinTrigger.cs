using UnityEngine.UI;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] Text timerText;
    public GameObject winCanvas;
    public Timer timer;
    public PlayerController playerController;

    void Start()
    {
        timer = GameObject.Find("Player").GetComponent<Timer>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // OnTriggerEnter is called when the gameObject is triggered
    void OnTriggerEnter(Collider player)
    {
        winCanvas.gameObject.SetActive(true);
        // Disable the timer
        player.GetComponent<Timer>().enabled = false;
        // Change TimerText's font size to 60
        timerText.fontSize = 60;
        // Change TimerText's color to green
        timerText.color = Color.green;
        timer.Win();
        playerController.enabled = false;
    }
}
