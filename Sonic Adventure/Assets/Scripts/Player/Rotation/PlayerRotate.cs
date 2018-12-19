using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : GroundedCheck {
    RaycastHit ray;
    protected const float rotateHeight = 1f;

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position + vectorOffset, -transform.up, out ray, rotateHeight, GroundMask))
        {
          //  transform.position = ray.point;
            Quaternion rotate = Quaternion.FromToRotation(Vector3.up, ray.normal);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotate, Time.time * 1);
        }
        else
        {
            transform.rotation = new Quaternion(0,0,0,0);
        }
    }
}
