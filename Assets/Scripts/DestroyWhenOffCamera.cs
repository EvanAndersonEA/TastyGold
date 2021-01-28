using UnityEngine;
using System.Collections;

public class DestroyWhenOffCamera : MonoBehaviour
{
    private Vector2 currentPosition;
    public Vector2 destroyWidth;
    public Vector2 destroyHeight;
    private Transform transform;
    private void Awake()
    {
        destroyHeight = new Vector2(-20 ,20);
        destroyWidth = new Vector2(-20, 20);
        transform = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        currentPosition = transform.position;
        if (currentPosition.x < destroyWidth.x || currentPosition.x > destroyWidth.y || currentPosition.y < destroyHeight.x || currentPosition.y > destroyHeight.y)
            Destroy(gameObject);
    }
}
