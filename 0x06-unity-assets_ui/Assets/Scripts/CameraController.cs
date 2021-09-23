using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 5f;
    [SerializeField] GameObject player;
    private Vector3 offset;
    float turnX;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            turnX += Input.GetAxis("Mouse X")  * mouseSensitivity;
            offset = Quaternion.AngleAxis (turnX, Vector3.up) * offset;
            transform.position = player.transform.position + offset;
            transform.LookAt(player.transform.position);
        }
        else
        {
        transform.position = player.transform.position + offset; 
        }
    }
}
