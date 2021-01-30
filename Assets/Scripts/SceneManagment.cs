using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public int health;
    public int gold;

    private void Awake()
    {
        Object.DontDestroyOnLoad(this.gameObject);
    }
    public void LoadPanningScene()
    {
        StartCoroutine(LoadScene("PanningScene"));
        StartCoroutine(LoseTimer(60));
    }

    public void LoadLoseScene()
    {
        StartCoroutine(LoadScene("LoseScene"));
        StopAllCoroutines();
    }

    IEnumerator LoseTimer(int time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(LoadScene("LoseScene"));
        StopAllCoroutines();
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
