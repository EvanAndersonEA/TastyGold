using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSprite : MonoBehaviour
{
    public List<Sprite> spritelist = new List<Sprite>();

    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = spritelist[Random.Range(0, spritelist.Count)];
    }
}
