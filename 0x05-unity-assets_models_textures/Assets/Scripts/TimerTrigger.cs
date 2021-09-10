using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider player)
    {
        // Enable the timer
        player.GetComponent<Timer>().enabled = true;
    }
}
