using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clipRockHit;
    public AudioClip clipGrassHit;

    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void LandSound()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            string floortag = hit.transform.parent.tag;
            if (floortag == "Grass")
            {
                audioSource.clip = clipGrassHit;
            }
            else if (floortag == "Rock")
            {
                audioSource.clip = clipRockHit;
            }
            audioSource.Play();
        }
    }
}
