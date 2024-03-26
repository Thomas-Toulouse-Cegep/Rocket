using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RocketMovement : MonoBehaviour
{
    [SerializeField] private float thrustForce = 10f;
    [SerializeField] private float rotationSpeed = 100f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GameObject camera = GameObject.Find("Main Camera");
        // add offset to camera so you can see the player
        camera.transform.position = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z - 10);
        
        // Rotation
        float yaw = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float pitch = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        transform.Rotate(-pitch, yaw, 0f);

        // Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.forward * (thrustForce * Time.deltaTime));
        }
    }
}