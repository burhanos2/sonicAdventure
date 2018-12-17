using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler {

    public void SwitchSceneSingle(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        return;
    }
    public void SwitchSceneMultiple(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        return;
    }
}
