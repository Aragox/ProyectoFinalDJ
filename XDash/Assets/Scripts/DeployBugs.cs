using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBugs : MonoBehaviour
{

    public GameObject bugPrefab;
    public float yPositionLimit;
    public float respawnTime;

    // Use this for initialization
    void Start()
    {
        startSpawn();
    }

    private void spawnBug()
    {
        float randomPosition = Random.Range(-yPositionLimit, yPositionLimit);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomPosition);
        Instantiate(bugPrefab, spawnPosition, Quaternion.identity);
    }

    public void startSpawn() {
        InvokeRepeating("spawnBug", 1f, respawnTime);
    }
 
}
