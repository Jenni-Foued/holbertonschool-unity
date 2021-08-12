using UnityEngine;

public class Rotator : MonoBehaviour
{
    float rotationDegree = 45f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationDegree * Time.deltaTime, 0, 0);
    }
}
