using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float gravity = -20f;
    public float jumpHeight = 2f;

    private CharacterController controller;
    private float verticalVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // Ground check
        if (controller.isGrounded)
        {
            if (verticalVelocity < 0)
                verticalVelocity = -2f;

            // JUMP INPUT
            if (Input.GetButtonDown("Jump")) // Spacebar by default
            {
                verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }

        // Apply gravity
        verticalVelocity += gravity * Time.deltaTime;

        Vector3 velocity = new Vector3(move.x * moveSpeed, verticalVelocity, move.z * moveSpeed);

        controller.Move(velocity * Time.deltaTime);
    }
}