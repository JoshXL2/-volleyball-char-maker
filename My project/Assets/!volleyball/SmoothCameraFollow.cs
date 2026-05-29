using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target;        // Player to follow
    public Vector3 offset;          // Offset from the player
    public float smoothSpeed = 5f;  // How smooth the movement is

    void LateUpdate()
    {
        if (target == null)
            return;

        // Desired position
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move the camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;

        // Optional: Always look at the player
        transform.LookAt(target);
    }
}