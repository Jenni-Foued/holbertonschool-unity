using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    // // OnTriggerExit is called when the gameObject exit trigger
    void OnTriggerExit(Collider player)
    {
        // Enable the timer
        player.GetComponent<Timer>().enabled = true;
    }
}
