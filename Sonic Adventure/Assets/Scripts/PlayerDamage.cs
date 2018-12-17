using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    public Rigidbody playerRB;
    private Pickup pickup;

    private bool invinstime = true;
    public Collider playerCollider2;
    public Collider spikecol;
    public float timer3 = 2;

    private void Awake()
    {
        pickup = GetComponent<Pickup>();
        playerRB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Invinstimer();
    }

    void OnDamage()
    {
        //LoseRings(pickup.count);
        Ringloss();
        AddKnockback(playerRB, -2, 2);
        Invinstimer();

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Spike")
        {
            invinstime = false;
            Physics.IgnoreCollision(playerCollider2, spikecol, ignore: true);
            OnDamage();
            
        }
        
    }

    public void AddKnockback(Rigidbody name, float range, float upValue)
    {
        name.AddForce(transform.forward * range, ForceMode.Impulse);
        name.AddForce(transform.up * upValue, ForceMode.Impulse);
    }

/*    private void LoseRings(int amount)
    {
        float oldAngle = 0;
        float newAngle = oldAngle;
        if (amount != 0)
        {
            oldAngle = 360 / amount;

            for (int i = 0; i < amount; i++)
            {
                newAngle += oldAngle;
                this.gameObject.transform.Rotate(0, 0, newAngle);
                AddKnockback(GetComponent<Rigidbody>(), 0.5f, 0.33f);
            }

        }
        else { Debug.Log("Player is dead"); return; }


    } */

    private void Ringloss()
    {
        if (pickup.count <= 20) {
            pickup.count -= pickup.count ;
            pickup.SetRings();

        } else {

            pickup.count -= pickup.count;
            pickup.SetRings();
        }

    }

    public void Invinstimer()
    {
        if (invinstime == false)
            timer3 -= 1 * Time.deltaTime;
        if (timer3 <= 0)
        {
            Physics.IgnoreCollision(playerCollider2, spikecol, ignore: false);
            invinstime = true;
            timer3 = 2;
        }
    }
}