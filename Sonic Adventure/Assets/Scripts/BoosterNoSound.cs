using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterNoSound : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;

    private readonly float boostPower = 0.8f;

    private void Awake()
    {
        player.GetComponent<Transform>();
        rb.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider playerCollider)
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(-this.transform.right * (boostPower * 100), ForceMode.VelocityChange);
    }

}

