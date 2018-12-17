using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour{

    public Animator anim;
    public Image blackImage;

    public void SwitchSceneSingle(string sceneName)
    {
        StartCoroutine(SingleFade(sceneName));
        return;
    }
    public void SwitchSceneMultiple(string sceneName)
    {
        StartCoroutine(MultipleFade(sceneName));
        return;
    }

    private IEnumerator SingleFade(string sceneName)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blackImage.color.a == 1);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    private IEnumerator MultipleFade(string sceneName)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blackImage.color.a == 1);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
}
