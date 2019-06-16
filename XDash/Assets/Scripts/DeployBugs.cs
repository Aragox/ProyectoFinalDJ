using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBugs : MonoBehaviour
{

    public GameObject buglv1;
    public GameObject buglv2;
    public GameObject particlel;
    public GameObject potion;
    public GameObject alakol1;
    public GameObject alakol2;
    public float yPositionLimit;

    // Use this for initialization
    void Start()
    {
        startSpawn();
    }

    private void spawnBug()
    {
        float randomPosition = Random.Range(-yPositionLimit, yPositionLimit);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomPosition);
        int picknumber = Random.Range(1, 11);
        switch (picknumber)
        {
            case 1:
                Instantiate(alakol2, spawnPosition, Quaternion.identity);
                break;
            case 2:
                Instantiate(alakol1, spawnPosition, Quaternion.identity);
                break;
            case 3:
                Instantiate(potion, spawnPosition, Quaternion.identity);
                break;
            case 4:
                Instantiate(particlel, spawnPosition, Quaternion.identity);
                break;
            case 5:
                Instantiate(buglv2, spawnPosition, Quaternion.identity);
                break;
            default:
                if (picknumber > 7)
                {
                    Instantiate(buglv1, spawnPosition, Quaternion.identity);
                }
                else
                {
                    Instantiate(particlel, spawnPosition, Quaternion.identity);
                }
                break;
        }
    }

    public void startSpawn()
    {
        float respawnTime = Random.Range(1.2f, 2.5f);
        InvokeRepeating("spawnBug", 1f, respawnTime);
    }

}
