using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{
    private LayerMask GroundMask;

    private const float CheckHeight = 0.52f;

    private bool _isGrounded;
    public bool Grounded {   get { return _isGrounded; }   }

    void Start()
    {
        GroundMask = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        Debug.DrawRay(transform.localPosition, -transform.up * CheckHeight,Color.cyan , 0f);
        //
        if (Physics.Raycast(transform.localPosition, -transform.up, CheckHeight, GroundMask))
        {
            if (_isGrounded == false)
            {
                _isGrounded = true;
                // _jumpSound.Play();
            }
        }
        else
        {
            if (_isGrounded == true)
            {
                _isGrounded = false;
            }
        }
    }
}
