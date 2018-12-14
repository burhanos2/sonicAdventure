using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposibleRing : MonoBehaviour {
    [SerializeField]
    private float timer = 1;
    private float timer2 = 0.25f;

    public Material mat;
    public Material mat2;

    public Collider collideRing;
    public GameObject playerObject;
    public Collider playerCollider;
    private bool requireTimer;
    private bool blinktimer;


    void UpdateTimer()
    {
        if (requireTimer == true) { 
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            Physics.IgnoreCollision(playerCollider, collideRing, ignore: false);
                requireTimer = false;
                timer = 1;
        }
      }
    }

    private void DestroyObject(float Time = 0)
    {
        Destroy(gameObject, Time);
    }

    private void Awake()
    {
        collideRing = GetComponent<Collider>();
        playerCollider = playerObject.GetComponent<Collider>();
        Physics.IgnoreCollision(playerCollider, collideRing, ignore: true);
        requireTimer = true;
        blinktimer = true;
    }

    private void Update()
    {
        UpdateTimer();
        ColorSwitch();
    }

    private void ColorSwitch()
    {
        if (blinktimer == true)
        {
            timer2 -= 1 * Time.deltaTime;
            if (timer2 <= 0)
            {
                gameObject.GetComponent<Renderer>().material = mat2;
                timer2 = 0.25f;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material = mat;
            }
        }
    }
}
