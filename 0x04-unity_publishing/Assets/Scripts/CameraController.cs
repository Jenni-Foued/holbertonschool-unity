using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 20, 0);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
