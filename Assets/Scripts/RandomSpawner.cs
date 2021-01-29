using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> hazards = new List<GameObject>();
    int hazardToSpawn;
    GameObject spawnedHazard;

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
        spawnedHazard = Instantiate(hazards[hazardToSpawn], new Vector3(9, Random.Range(-5f, 5f), 0), Quaternion.identity);
        spawnedHazard.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-50f, 50f);
    }

}
