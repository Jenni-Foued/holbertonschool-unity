using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private float verticalVelocity;
    private float groundedTimer;
    [SerializeField] float playerSpeed = 10.0f;
    [SerializeField] float jumpHeight = 3.0f;
    [SerializeField] float gravityValue = 20f;
    [SerializeField] Transform cameraTransform;
    static Animator animator;

    void Awake()
    {
        controller = gameObject.GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        bool groundedPlayer = controller.isGrounded;
        if (groundedPlayer)
        {
            // cooldown interval to allow reliable jumping even when coming down ramps
            groundedTimer = 0.2f;

            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
            animator.SetBool("isGrounded", true);
        }
        else
            animator.SetBool("isGrounded", false);
        if (groundedTimer > 0)
        {
            groundedTimer -= Time.deltaTime;
        }

        // slam into the ground
        if (groundedPlayer && verticalVelocity < 0)
        {
            // hit ground
            verticalVelocity = 0f;
        }

        // apply gravity always, to let us track down ramps properly
        verticalVelocity -= gravityValue * Time.deltaTime;

        // gather lateral input control
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        // scale by speed
        moveDirection *= playerSpeed;

        // rotate with the camera
        moveDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * moveDirection;

        // only align to motion if we are providing enough input
        if (moveDirection.magnitude > 0.05f)
        {
            gameObject.transform.forward = moveDirection;
            animator.SetBool("isRunning", true);
        }
        else
            animator.SetBool("isRunning", false);

        // allow jump as long as the player is on the ground
        if (Input.GetButtonDown("Jump"))
        {
            // must have been grounded recently to allow jump
            if (groundedTimer > 0)
            {
                // no more until we recontact ground
                groundedTimer = 0;

                // Physics dynamics formula for calculating jump up velocity based on height and gravity
                verticalVelocity += Mathf.Sqrt(jumpHeight * 2 * gravityValue);
                animator.SetBool("isJumping", true);
            }
        }


        // inject Y velocity before we use it
        moveDirection.y = verticalVelocity;

        // call .moveDirection() once only
        controller.Move(moveDirection * Time.deltaTime);


        // Falling animation
        if (transform.position.y < -5.0f)
            animator.SetBool("isFalling", true);

        // reset the game
        if (transform.position.y < -30.0f)
        {
            transform.position = new Vector3(0.0f, 30.0f, 0.0f);
        }
        
    }
}
