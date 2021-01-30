using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public bool health;

    SceneManagment sceneManager;

    [SerializeField]
    TextMeshProUGUI loseMessage;

    private void Awake()
    {
        sceneManager = FindObjectOfType<SceneManagment>();

        GetComponent<TextMeshProUGUI>().text = ("Score: " + (((sceneManager.health - 5) * 20) + sceneManager.gold *20).ToString());
        if (sceneManager.health <= 0)
        {
            loseMessage.text = ("Mercurey Poisoning Gets the Best of us");
        }
        else
        {
            loseMessage.text = ("The day is done");
        }
    }

}
