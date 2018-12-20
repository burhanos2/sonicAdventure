using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour {

    private SceneHandler restart;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            restart.SwitchSceneSingle("Main");
        }	
	}
    private void Awake()
    {
        restart = GetComponent<SceneHandler>();
    }
}
