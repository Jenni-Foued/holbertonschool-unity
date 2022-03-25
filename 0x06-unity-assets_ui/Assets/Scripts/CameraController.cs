using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 5f;
    [SerializeField] GameObject player;
    private Vector3 offset;
    private float mouseY;

    public bool isInverted;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        if (PlayerPrefs.HasKey("InvertYToggle"))
            isInverted = PlayerPrefs.GetInt("InvertYToggle") != 0;
        else 
            isInverted = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Temporary rotation (Needs an update)
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseSensitivity, Vector3.up) * offset;
        if (!isInverted)
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * mouseSensitivity, Vector3.right) * offset;
        else
            offset = Quaternion.AngleAxis(-(Input.GetAxis("Mouse Y") * mouseSensitivity), Vector3.right) * offset;
        transform.position = player.transform.position + offset;

        transform.LookAt(player.transform.position);
    }
}
