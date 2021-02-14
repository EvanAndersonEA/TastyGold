using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public bool health;

    SceneManagment sceneManager;

    private void Awake()
    {
        sceneManager = FindObjectOfType<SceneManagment>();

        GetComponent<TextMeshProUGUI>().text = ("Score: " + (((sceneManager.health) * 10) + sceneManager.gold *20).ToString());
    }

}
