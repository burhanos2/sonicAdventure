using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public Text time;
    public float minutes = 0f;
    public float seconds = 0f;
    public float miliseconds = 0f;
	
	void Update () {
        timeUpdate();
	}

    public void timeUpdate()
    {
        if (miliseconds >= 96)
        {
            seconds++;
            miliseconds = 0;
        }
        if (seconds >= 59)
        {
            minutes++;
            seconds = 0;
        }

        miliseconds += Time.deltaTime * 100;

        time.text = string.Format ("time: {0}:{1}:{2}", minutes, seconds, (int)miliseconds);
    }
}
