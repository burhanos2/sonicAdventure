using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{
    protected LayerMask GroundMask;
    public Vector3 vectorOffset = new Vector3(0,0,0.12f);

    protected const float CheckHeight = 0.7f;

    private bool _isGrounded;
    public bool Grounded {   get { return _isGrounded; }   }

    void Awake()
    {
        GroundMask = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        Debug.DrawRay(transform.localPosition + vectorOffset, -transform.up * CheckHeight,Color.cyan , 0f);
        //
        if (Physics.Raycast(transform.localPosition + vectorOffset, -transform.up, CheckHeight, GroundMask))
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
