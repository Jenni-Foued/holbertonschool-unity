using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] Text finalTimeText;
    float startTime;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timer = Time.time - startTime;
        string minutes = ((int)timer / 60).ToString();
        string seconds = (timer % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
    }

    public void Win()
    {
        finalTimeText.text = timerText.text;
    }
}
