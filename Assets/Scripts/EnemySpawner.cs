using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float xPositionLimit;
    public float spawnRate;


    void Start()
    {
        //SpawnSpike();
        StartSpawing();
    }

    void SpawnSpike()
    {
        float randomX = Random.Range(-xPositionLimit, xPositionLimit);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
    void StartSpawing()
    {
        InvokeRepeating("SpawnSpike", 1f, spawnRate);
    }
    public void StopSpawing()
    {
        CancelInvoke("SpawnSpike");
    }

}
