using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour {

    public Rigidbody rb;
    public Transform player;
    public AudioSource audioFile;

    public float boostPower;

    private void Awake()
    {
        player.GetComponent<Transform>();
        rb.GetComponent<Rigidbody>();
        audioFile.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider playerCollider)
    {
        rb.AddForce(player.forward * boostPower, ForceMode.VelocityChange);
        audioFile.Play(0);
    }
    
}
