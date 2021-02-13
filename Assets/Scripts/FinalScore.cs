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

        GetComponent<TextMeshProUGUI>().text = ("Score: " + (((sceneManager.health - 5) * 20) + sceneManager.gold *20).ToString());
    }

}
