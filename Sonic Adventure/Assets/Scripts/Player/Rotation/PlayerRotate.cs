using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : GroundedCheck {
    RaycastHit ray;
    
    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, -transform.up, out ray, CheckHeight, GroundMask))
        {
          //  transform.position = ray.point;
            Quaternion rotate = Quaternion.FromToRotation(Vector3.up, ray.normal);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotate, Time.time * 1);
        }
    }
}
