using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    public Rigidbody playerRB;
    private Pickup pickup;
    private SceneHandler sceneHandler;

    private bool invinstime = true;
    public Collider playerCollider2;
    public Collider spikecol;
    public float timer3 = 2;

    private void Awake()
    {
        pickup = GetComponent<Pickup>();
        playerRB = GetComponent<Rigidbody>();
        sceneHandler = GetComponent<SceneHandler>();
    }

    void OnDamage(float horizontalKB, float verticalKB)
    {
        //LoseRings(pickup.count);
        Ringloss();
        AddKnockback(playerRB, horizontalKB, verticalKB);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Spike")
        {
          invinstime = false;
          Physics.IgnoreCollision(playerCollider2, spikecol, ignore: true);
            OnDamage(-2, 2);
        }

        if (other.gameObject.tag == "Water")
        {
            OnDamage(0, 0);
            RespawnSonic();
        }

    }

    private void RespawnSonic()
    {
        Debug.Log("HI");
        sceneHandler.SwitchSceneSingle("JochemTest");
    }

    public void AddKnockback(Rigidbody name, float range, float upValue)
    {
        name.AddForce(transform.forward * range, ForceMode.Impulse);
        name.AddForce(transform.up * upValue, ForceMode.Impulse);
    }

/*    Dit stuk is voor het fancy ring drop effect wat te veel moeite was voor iets dat niet in de 10sec clip zat.

     private void LoseRings(int amount)
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
        pickup.count -= pickup.count;
        pickup.SetRings();

        if (pickup.count < 0)
        {
            pickup.count = 0;
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
