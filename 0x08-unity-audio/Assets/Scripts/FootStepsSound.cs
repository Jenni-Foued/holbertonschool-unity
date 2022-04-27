using UnityEngine;

public class FootStepsSound : MonoBehaviour
{
    private AudioSource audioSource;
    private Animator animator;
    private CharacterController characterController;
    public AudioClip clipGrass;
    public AudioClip clipRock;
    WinTrigger trigger;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponentInChildren<Animator>();
        characterController = GetComponent<CharacterController>();
        trigger = GameObject.Find("WinFlag").GetComponent<WinTrigger>();
    }

    private void Update()
    {
        if (animator.GetBool("isRunning"))
            StepsSound();
    }

    void StepsSound()
    {
        if (characterController.isGrounded && !trigger.isFinished)
        {
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {
                string floortag = hit.transform.parent.tag;
                if (floortag == "Grass")
                {
                    audioSource.clip = clipGrass;
                }
                else if (floortag == "Rock")
                {
                    audioSource.clip = clipRock;
                }
            }
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
            audioSource.Stop();
    }
}
