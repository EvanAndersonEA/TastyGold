using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    int health = 20;
    int gold = 0;

    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] TextMeshProUGUI loseText;

    Collider2D lastCollider = null;

    private void Awake()
    {
        healthText.text = health.ToString();
        loseText.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hazard" && lastCollider != collision.collider)
        {
            if(health <= 0)
            {
                loseText.gameObject.SetActive(true);
            }
            else
            {
                health--;
                healthText.text = health.ToString();
            }
        }
        else if(collision.gameObject.tag == "Gold" && lastCollider != collision.collider)
        {
            gold++;
            goldText.text = gold.ToString();
            Destroy(collision.gameObject);
        }
        lastCollider = collision.collider;
    }
}
