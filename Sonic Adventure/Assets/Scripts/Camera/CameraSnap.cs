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
            cam.transform.position = other.transform.GetChild(0).position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CameraTrigger")
        { 
        _trigCount--;
        }
    }

    private void Update()
    {
        if (_trigCount == 0)
        { tfollow.FollowTargetInPos(); }
    }

}
