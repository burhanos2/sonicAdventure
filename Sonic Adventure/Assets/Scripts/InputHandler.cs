using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    private KeyCode pressedKey;

	private void DetectKey()
    {
        foreach (KeyCode detected_key in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(detected_key))
            {
                pressedKey = detected_key;
            }
        }
        return;
    }

    private void SetInputbutton()
    {
        if (Input.anyKeyDown) {
            DetectKey();
            Debug.Log(pressedKey);
        }
    }

}
