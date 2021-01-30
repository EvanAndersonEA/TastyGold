using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    SceneManagment sceneManagment;

    private void Awake()
    {
        sceneManagment = FindObjectOfType<SceneManagment>();
    }

    public void PlayAgainButtonPress()
    {
        sceneManagment.LoadPanningScene();
    }

    IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
