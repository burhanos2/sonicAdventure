using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public Text RingsAmount;
    [HideInInspector]
    public int count;
    public AudioSource ringPick;

    [SerializeField]
    private AudioClip pickSound;

	// Use this for initialization
	void Start () {
        count = 0;
        SetRings();
        ringPick.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            ringPick.PlayOneShot(pickSound);
            Destroy(other.gameObject);
            count = count + 1;
            SetRings();
            //Debug.Log(count);
        }
    }

    public void SetRings()
    {
        RingsAmount.text = "" + count;
    }
}
