using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningOnPoints : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "RotatePoint")
        {
            Rotate45Deg(other.gameObject.GetComponent<RotatePointAmount>().timesToRotate45Deg);
        }
    }


    private void Rotate45Deg(int times)
    { transform.Rotate(Vector3.up * Time.deltaTime * 2250 * times, Space.Self); }

}
