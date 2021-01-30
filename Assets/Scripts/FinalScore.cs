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
        if (health == true)
        {
            GetComponent<TextMeshProUGUI>().text = sceneManager.health.ToString();
            if(sceneManager.health <= 0)
            {
                loseMessage.text = ("Mercurey Poisoning Gets the Best of us");
            }
            else
            {
                loseMessage.text = ("The day is done");
            }
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = sceneManager.gold.ToString();
        }
    }

}
