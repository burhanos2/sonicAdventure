using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

    private Animator anim;
    private bool playerDeath = false;

    [SerializeField]
    private Camera cam1,
                   cam2;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

        cam1.enabled = true;
        cam2.enabled = false;

        //if (playerDeath = true)
        //{
        //    cam2.enabled = !cam2.enabled;
        //}

    }
    // update with cam switch
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }
    }
    // Death 
    private void Death()
    {
        anim.Play("Death");
        playerDeath = true;
    }
}



