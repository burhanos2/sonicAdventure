using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;

    public float maxSpeed;
    public float movementSpeed;
    public float stopSpeed;

    private void Update()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            movementSpeed = maxSpeed;
        }
    }

    private void FixedUpdate()
    {
        WaitForInput();
        StopMoving();
    }

    private void WaitForInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Camera.main.transform.forward * movementSpeed * 10, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Camera.main.transform.forward * movementSpeed * 10, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Camera.main.transform.right * movementSpeed * 10, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Camera.main.transform.right * movementSpeed * 10, ForceMode.Acceleration);
        }
    }

    private void StopMoving()
    {
        if (Input.anyKey != true)
        {
            rb.velocity -= rb.velocity * stopSpeed * Time.deltaTime;
        }
    }

}
