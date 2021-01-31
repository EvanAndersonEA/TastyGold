using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public int health;
    public int gold;
    [SerializeField] AudioClip bloodMusic;
    [SerializeField] AudioClip riverMusic;
    [SerializeField] AudioClip poolMusic;

    private void Awake()
    {
        Object.DontDestroyOnLoad(this.gameObject);
    }

    public void LoadRiverScene()
    {
        StartCoroutine(LoadScene("RiverScene"));
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 0.4f;
        GetComponent<AudioSource>().PlayOneShot(riverMusic);
        StartCoroutine(DayTimerRiver(40));
        Debug.Log("timer started");
    }
    public void LoadPoolScene()
    {
        StartCoroutine(LoadScene("PoolScene"));
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 0.4f;
        GetComponent<AudioSource>().PlayOneShot(riverMusic);
        StartCoroutine(DayTimerPool(40));
        Debug.Log("timer started");
    }

    public void LoadBloodScene()
    {
        StartCoroutine(LoadScene("BloodScene"));
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 1f;
        GetComponent<AudioSource>().PlayOneShot(bloodMusic);
        StartCoroutine(DayTimerBlood(40));
        Debug.Log("timer started");
    }

    public void LoadLoseScene()
    {
        StartCoroutine(LoadScene("LoseScene"));
        StopAllCoroutines();
        Debug.Log("timer ended");
    }

    IEnumerator DayTimerRiver(int time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(LoadScene("DayDoneRiver"));
        StopAllCoroutines();
        Debug.Log("timer ended");
    }

    IEnumerator DayTimerPool(int time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(LoadScene("DayDonePool"));
        StopAllCoroutines();
        Debug.Log("timer ended");
    }
    IEnumerator DayTimerBlood(int time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(LoadScene("LoseScene"));
        StopAllCoroutines();
        Debug.Log("timer ended");
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
