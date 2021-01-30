﻿using System.Collections;
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
        StartCoroutine(LoseTimer(30));
    }

    public void LoadLoseScene()
    {
        StartCoroutine(LoadScene("LoseScene"));
    }

    IEnumerator LoseTimer(int time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(LoadScene("LoseScene"));
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