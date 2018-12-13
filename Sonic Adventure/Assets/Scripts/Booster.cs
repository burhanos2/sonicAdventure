using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour {

    public Rigidbody rb;
    public Transform player;
    public AudioSource audioFile;

    private float boostPower = 1;

    private void Awake()
    {
        player.GetComponent<Transform>();
        rb.GetComponent<Rigidbody>();
        audioFile.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider playerCollider)
    {
        rb.AddForce(this.transform.forward * (boostPower * 100), ForceMode.VelocityChange);
        audioFile.Play(0);
    }
    
}
