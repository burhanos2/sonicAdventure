using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnims : MonoBehaviour {

    public Animator sonicAnimator;
    private PlayerMovement movementScript;
    private PlayerDamage playerDamage;

    [HideInInspector]
    public int damageState = 0;

    private void Awake()
    {
        playerDamage = GetComponent<PlayerDamage>();
        movementScript = GetComponent<PlayerMovement>();
        sonicAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        AdjustAnimation();
    }

    private void AdjustAnimation() {
        sonicAnimator.SetFloat("movementSpeed", movementScript.rb.velocity.magnitude);
        sonicAnimator.SetInteger("damageState", damageState);
    }

    public void DamageAnimation()
    {
        playerDamage.invinstime = false;
        damageState = 1;
    }
}
