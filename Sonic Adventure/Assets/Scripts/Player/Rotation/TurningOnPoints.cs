using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningOnPoints : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "RotatePoint")
        {
            RotateIt(other.gameObject.GetComponent<RotatePointAmount>().times);
        }
    }

    /// <summary>
    /// times is the amount of times it wil rotate 45 degrees
    /// </summary>
    /// <param name="times"></param>
    private void RotateIt(int times)
    { transform.Rotate(Vector3.up * Time.deltaTime * 2250 * times, Space.Self); }

}
