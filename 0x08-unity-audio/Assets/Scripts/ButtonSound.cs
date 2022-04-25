using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hoverAudioClip;
    public AudioClip pressedAudioClip;

    public void HoverSound()
    {
        audioSource.PlayOneShot(hoverAudioClip);
    }

    public void ClickSound()
    {
        audioSource.PlayOneShot(pressedAudioClip);
    }
}
