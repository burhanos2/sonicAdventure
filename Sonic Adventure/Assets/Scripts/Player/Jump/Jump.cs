using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private KeyCode jumpKey = KeyCode.Space;

    [SerializeField]
    private float jumpForce = 2;

    private const float jumpTime = 1;
   
    private float jumpTimeCounter;

    private bool isJumping = false;
    public bool Jumping { get { return isJumping; } }

    private Rigidbody rb;

    private GroundedCheck groundCheck;

	private void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
        groundCheck = GetComponent<GroundedCheck>();
	}
	
	private void FixedUpdate ()
    {
        DoJump();
	}

    private void ZeroVel()
    {
        rb.velocity = Vector3.zero;
    }

    private void DoJump()
    {

        if (groundCheck.Grounded == true && Input.GetKeyDown(jumpKey))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = new Vector3(rb.velocity.x, jumpForce * 2f, rb.velocity.z);
        }
        else if (Input.GetKey(jumpKey) && isJumping == true)
        {

            if (jumpTimeCounter > 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }

        }

        if (Input.GetKeyUp(jumpKey))
        {
            isJumping = false;
        }
    }
}
