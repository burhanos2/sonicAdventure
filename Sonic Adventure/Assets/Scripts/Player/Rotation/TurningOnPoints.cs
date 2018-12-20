using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningOnPoints : MonoBehaviour {
    //could have made this into a list read through by a for loop but i just needed something quick
    [SerializeField]
    private Transform anims1, anims2, anims3;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RotatePoint")
        {
            RotateIt(other.gameObject.GetComponent<RotatePointAmount>().times, anims1);
            RotateIt(other.gameObject.GetComponent<RotatePointAmount>().times, anims2);
            RotateIt(other.gameObject.GetComponent<RotatePointAmount>().times, anims3);
        }
    }

    /// <summary>
    /// times is the amount of times it wil rotate 45 degrees
    /// </summary>
    /// <param name="times"></param>
    private void RotateIt(int times, Transform trans)
    { trans.Rotate(Vector3.up * Time.deltaTime * 2250 * times, Space.World); }

}
