using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;      // Reference to the player (the plane)
    public Vector3 offset;        // The offset distance between the camera and the player
    public float smoothSpeed = 0.125f; // Speed of camera movement
    public bool rotateWithPlayer = true; // Flag to enable camera rotation with the plane

    // Update is called once per frame
    void LateUpdate()
    {
        // Calculate the desired position based on the player's position and the offset
        Vector3 desiredPosition = player.position + offset;

        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;

        // If rotateWithPlayer is enabled, rotate the camera to match the plane's rotation
        if (rotateWithPlayer)
        {
            // Match the camera's rotation with the player's rotation on the y-axis
            transform.rotation = Quaternion.Euler(0, player.eulerAngles.y, 0);
        }

        // Optionally, make the camera always look at the player
        transform.LookAt(player);
    }
}

