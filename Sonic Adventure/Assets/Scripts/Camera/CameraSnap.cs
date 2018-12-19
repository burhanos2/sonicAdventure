using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSnap : MonoBehaviour
{
    [SerializeField]
    private GameObject cam;
    private TargetFollower tfollow;
    private short _trigCount;

    private void Start()
    {
        _trigCount = 0;
        tfollow = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TargetFollower>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CameraTrigger")
        {
            _trigCount++;
           cam.transform.position = other.gameObject.GetComponentInParent<Transform>().position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _trigCount--;
    }

    private void FixedUpdate()
    {
        if (_trigCount == 0)
        { tfollow.FollowTargetInPos(); }
    }

}
