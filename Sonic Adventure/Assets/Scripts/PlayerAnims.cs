using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnims : MonoBehaviour {

    public Animator sonicAnimator;
    private PlayerMovement movementScript;
    private Animation anim;
    private float walkSpeed = 1.1f;
    private float runSpeed = 2.9f;

    private void Awake()
    {
        
        movementScript = GetComponent<PlayerMovement>();
        sonicAnimator = GetComponent<Animator>();
    }

    private void AdjustAnimation() {

        if (movementScript.rb.velocity.magnitude <= 0)
        {
            anim.Play("Idle", PlayMode.StopAll);
        }
        if (movementScript.rb.velocity.magnitude > 0 && movementScript.rb.velocity.magnitude < walkSpeed)
        {
            anim.Play("Walk", PlayMode.StopAll);
        }
        if (movementScript.rb.velocity.magnitude > runSpeed)
        {
            anim.Play("Run", PlayMode.StopAll);
        }
    }

    public void DamageAnimation()
    {
        anim.Play("Hit", PlayMode.StopAll);
    }
}
