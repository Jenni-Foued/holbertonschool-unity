using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 cameraOffset;

    public Transform player;

    public float sensitivity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cameraOffset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up) * cameraOffset;
        transform.position = player.position + cameraOffset;

        transform.LookAt(player.position);

    }


}
