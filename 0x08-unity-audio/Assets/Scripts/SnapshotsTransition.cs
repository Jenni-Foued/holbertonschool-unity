using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class SnapshotsTransition : MonoBehaviour
{
    public AudioMixerSnapshot pauseSnapshot;
    public AudioMixerSnapshot unpausedSnapshot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SnapshotTransition();
    }

    void SnapshotTransition()
    {
        if (Time.timeScale == 1)
        {
            unpausedSnapshot.TransitionTo(0.1f);
        }
        else if (Time.timeScale == 0)
        {
            pauseSnapshot.TransitionTo(0.1f);
        }
    }
}
