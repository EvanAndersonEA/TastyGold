using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> hazards = new List<GameObject>();
    int hazardToSpawn;
    GameObject spawnedHazard;
    public const float timertime = 0.2f;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
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
        spawnedHazard = Instantiate(hazards[hazardToSpawn], new Vector3(9, Random.Range(-5, 5), 0), Quaternion.identity);
        spawnedHazard.GetComponent<Rigidbody2D>().velocity = new Vector3(-20, 0, 0);
    }

}
