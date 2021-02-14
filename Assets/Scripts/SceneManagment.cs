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
        LoadMyScene("RiverScene");
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 0.4f;
        GetComponent<AudioSource>().PlayOneShot(riverMusic);
        StartCoroutine(DayTimerRiver(60));
        Debug.Log("timer started");
    }
    public void LoadPoolScene()
    {
        LoadMyScene("PoolScene");
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 0.4f;
        GetComponent<AudioSource>().PlayOneShot(riverMusic);
        StartCoroutine(DayTimerPool(60));
        Debug.Log("timer started");
    }

    public void LoadBloodScene()
    {
        LoadMyScene("BloodScene");
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 1f;
        GetComponent<AudioSource>().PlayOneShot(bloodMusic);
        StartCoroutine(DayTimerBlood(60));
        Debug.Log("timer started");
    }

    public void LoadLoseScene()
    {
        LoadMyScene("LoseScene");
        StopAllCoroutines();
        Debug.Log("timer ended");
    }

    IEnumerator DayTimerRiver(int time)
    {
        yield return new WaitForSeconds(time);
        LoadMyScene("DayDoneRiver");
        StopAllCoroutines();
        Debug.Log("timer ended");
    }
     
    IEnumerator DayTimerPool(int time)
    {
        yield return new WaitForSeconds(time);
        LoadMyScene("DayDonePool");
        StopAllCoroutines();
        Debug.Log("timer ended");
    }
    IEnumerator DayTimerBlood(int time)
    {
        yield return new WaitForSeconds(time);
        LoadMyScene("MainMenu");
        StopAllCoroutines();
        Debug.Log("timer ended");
    }

    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
