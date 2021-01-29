using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkFurtherUp : MonoBehaviour
{
    float yPos;
    public float scalesize = 1;

    private void Awake()
    {
        GetComponent<Transform>().eulerAngles = new Vector3(180, 0, 0);
    }
    void Update()
    {
        yPos = transform.position.y - 12;
        GetComponent<Transform>().localScale = new Vector3(yPos * scalesize, yPos * scalesize, yPos * scalesize);
    }
}
