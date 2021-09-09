using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    float jumpForce = 10f;
    float speed = 10f;
    Rigidbody rb;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        transform.Translate(horizontalInput, 0, verticalInput);

        // Restart the game if the player falls
        if(transform.position.y < -30)
        {
            transform.position = new Vector3(0, 30, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
