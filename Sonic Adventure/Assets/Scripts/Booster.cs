using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour {

    public Rigidbody rb;
    public Transform player;
    public AudioSource audioFile;

    private readonly float boostPower = 1.25f;

    private void Awake()
    {
        player.GetComponent<Transform>();
        rb.GetComponent<Rigidbody>();
        audioFile.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider playerCollider)
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(-this.transform.right * (boostPower * 100), ForceMode.VelocityChange);
        audioFile.Play();
    }
    
}
