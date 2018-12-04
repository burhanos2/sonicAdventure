using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public Text RingsAmount;
    private int count;

	// Use this for initialization
	void Start () {
        count = 0;
        SetRings();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetRings();
            Debug.Log(count);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    void SetRings()
    {
        RingsAmount.text = "Rings: " + count.ToString();
    }
}
