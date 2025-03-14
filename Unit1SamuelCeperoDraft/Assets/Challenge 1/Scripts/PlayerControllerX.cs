using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical and horizontal input (WASD)
        verticalInput = Input.GetAxis("Vertical"); // W and S keys, or up and down arrows
        horizontalInput = Input.GetAxis("Horizontal"); // A and D keys, or left and right arrows

        // move the plane forward at a constant rate based on speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane based on the vertical input (W/S for up/down tilt)
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);

        // roll the plane based on the horizontal input (A/D for left/right roll)
        transform.Rotate(Vector3.forward * horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
