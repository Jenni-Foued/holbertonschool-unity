using UnityEngine.UI;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] Text timerText;
    public GameObject winCanvas;
    private Timer timer;
    private PlayerController playerController;
    private Animator animator;
    private AudioSource audioSource;
    private AudioSource bgAudioSource;
    private AudioSource winAudioSource;
    public bool isFinished = false;

    void Start()
    {
        timer = GameObject.Find("Player").GetComponent<Timer>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        animator = GameObject.Find("Player").GetComponentInChildren<Animator>();
        audioSource = GameObject.Find("Player").GetComponent<AudioSource>();
        bgAudioSource = GameObject.Find("BG Music").GetComponent<AudioSource>();
        winAudioSource = GetComponent<AudioSource>();
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
        animator.enabled = false;
        audioSource.enabled = false;
        isFinished = true;
        bgAudioSource.enabled = false;
        winAudioSource.Play();
    }
}
