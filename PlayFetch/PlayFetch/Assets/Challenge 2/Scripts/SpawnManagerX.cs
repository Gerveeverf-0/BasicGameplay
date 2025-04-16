using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;
    public float spawnInterval;
    private int minSpawnInterval = 1;
    private int maxSpawnInterval = 10;

    // Start is called before the first frame update
    void Start()
    {
        // set the initial spawn interval to a random value
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        
        // starts the spawning
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnRandomBall", spawnInterval);
    }

}
