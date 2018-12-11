using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    public Rigidbody playerRB;


    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void OnDamage()
    {
        LoseRings();
        AddKnockback(2);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Spike")
        {
            OnDamage();
        }
        
    }

    private void LoseRings()
    {

    }

    private void AddKnockback(float range)
    {
        playerRB.AddForce(-transform.forward * range, ForceMode.Impulse);
        playerRB.AddForce(transform.up * range, ForceMode.Impulse);
    }
}