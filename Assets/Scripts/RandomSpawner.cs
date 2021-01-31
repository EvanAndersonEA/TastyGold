using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> hazards = new List<GameObject>();
    int hazardToSpawn;
    GameObject spawnedHazard;

    public bool randomY;
    public float timertime = 0.001f;
    private float timeLeft;

    private void Awake()
    {
        timeLeft = timertime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft <= 0)
        {
            SpawnObstacle();
            timeLeft = timertime;
        }
        else
        {
            timeLeft -= Time.deltaTime;
        }
    }

    void SpawnObstacle()
    {
        hazardToSpawn = Random.Range(0, hazards.Count);

        if (randomY == true)
        {
            spawnedHazard = Instantiate(hazards[hazardToSpawn], new Vector3(15, Random.Range(-4f, 3f), 0), Quaternion.identity);
        }
        else
        {
            spawnedHazard = Instantiate(hazards[hazardToSpawn], new Vector3(15, -1f, 0), Quaternion.identity);
        }
        spawnedHazard.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-50f, 50f);
    }

}
