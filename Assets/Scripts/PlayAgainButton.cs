using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    SceneManagment sceneManagment;
    public int whatscene;


    private void Awake()
    {
        sceneManagment = FindObjectOfType<SceneManagment>();
    }

    public void PlayAgainButtonPress()
    {
        StopAllCoroutines();
        Debug.Log("timerEnded");
        if(whatscene == 1)
        {
            sceneManagment.LoadPoolScene();
        }else if(whatscene == 2)
        {
            sceneManagment.LoadBloodScene();
        }else
        {
            sceneManagment.LoadRiverScene();
        }
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
