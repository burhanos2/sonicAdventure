using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    [SerializeField]
    private float travelDurationDown = 1f;
    [SerializeField]
    private float travelDurationUp = 2f;

    private Vector3 pointA;
    private Vector3 pointB;

    private bool isUp,
                 isWaiting;

    


    // start
    private void Start()
    {
        // punten waar tussen de spike op en neer gaat
        pointA = new Vector3((float)-1.43, (float)5.632,(float)8.161);
        pointB = new Vector3((float)-1.43, (float)2.64, (float)8.161);

        StartCoroutine(Timer());
    }

    // Move between points, with timer
    private IEnumerator Timer()
    {
        // Loop 
        while (Application.isPlaying)
        {
            //Travel from A to B
            float speed = 0f;
            while (speed < travelDurationDown)
            {
                transform.position = Vector3.Lerp(pointA, pointB, speed / travelDurationDown);
                speed += Time.deltaTime;
                yield return null;
            }

            // In case the counter isn't equal to the travelDuration
            transform.position = pointB;

            // wait
            yield return new WaitForSeconds(1f);

            //Travel back from B to A
            float speed2 = 0f;
            while (speed2 < travelDurationUp)
            {
                transform.position = Vector3.Lerp(pointB, pointA, speed2 / travelDurationUp);
                speed2 += Time.deltaTime;
                yield return null;
            }

            transform.position = pointA;

            // Finally, wait
            yield return new WaitForSeconds(4f);
        }
    }

    //private void ChangeUpDown(bool value)
    //{
    //    isUp = value;
    //    isWaiting = true;
    //}
    //// update
    //private void Update()
    //{
    //    if (pointA == transform.position)
    //    {
    //        ChangeUpDown(true);
    //    }
    //    if (pointB == transform.position)
    //    {
    //        ChangeUpDown(false);
    //    }

    //    if (isWaiting = true)
    //    {
    //        switch (isUp)
    //        {
    //            case true:
    //                transform.position = Vector3.MoveTowards(transform.position, pointB, speed * Time.deltaTime);

    //                break;
    //            case false:
    //                transform.position = Vector3.MoveTowards(transform.position, pointA, speed * Time.deltaTime);

    //                break;
    //        }
    //    }

    //    if (isWaiting = true)
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, pointB, speed * Time.deltaTime);

    //    }
    //}
}
