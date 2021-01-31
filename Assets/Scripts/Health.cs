using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    int localHealth;
    int localGold;

    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] AudioManager audioManager;
    private SceneManagment sceneManager;

    Collider2D lastCollider = null;

    private void Awake()
    {
        sceneManager = FindObjectOfType<SceneManagment>();
        sceneManager.GetComponent<SceneManagment>().health = 10;
        sceneManager.GetComponent<SceneManagment>().gold = 0;
        healthText.text = sceneManager.GetComponent<SceneManagment>().health.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hazard" && lastCollider != collision.collider)
        {
            if(sceneManager.GetComponent<SceneManagment>().health <= 0)
            {
                sceneManager.LoadLoseScene();
            }
            else
            {
                sceneManager.GetComponent<SceneManagment>().health--;
                audioManager.PlayHurtSound();
                healthText.text = (sceneManager.GetComponent<SceneManagment>().health).ToString();
            }
        }
        else if(collision.gameObject.tag == "Gold")
        {
            sceneManager.GetComponent<SceneManagment>().gold++;
            audioManager.PlayCollectSound();
            goldText.text = sceneManager.GetComponent<SceneManagment>().gold.ToString();
            Destroy(collision.gameObject);
        }
        lastCollider = collision.collider;
    }
}
