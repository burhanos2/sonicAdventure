using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [SerializeField]
    private KeyCode jumpButton = KeyCode.Space;

    [SerializeField]
    private float jumpForce, jumpTime;

    [SerializeField]
    private LayerMask whatIsGround;

    private float jumpTimeCounter;

    private bool isGrounded = true, isJumping = false;

    private Rigidbody rb;

	private void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	
	private void Update ()
    {
        DoJump();
	}

    private void ZeroVel()
    {
        rb.velocity = Vector3.zero;
    }

    private void DoJump()
    {
        if (Input.GetKey(jumpButton))
        {
            rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        }
    }

}
