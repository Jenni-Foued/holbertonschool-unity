using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSourceClick;
    public AudioSource audioSourceHover;

    private void Awake()
    {
        audioSourceClick = GameObject.Find("MenuSFX").transform.GetChild(0).GetComponent<AudioSource>();
        audioSourceHover = GameObject.Find("MenuSFX").transform.GetChild(1).GetComponent<AudioSource>();
    }

    public void HoverSound()
    {
        audioSourceHover.Play();
    }

    public void ClickSound()
    {
        audioSourceClick.Play();
    }
}
