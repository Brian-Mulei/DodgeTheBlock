using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerSpawner : MonoBehaviour
{ 
     public Transform[] spawnPoints;
public GameObject block;
public float timeBetweenWaves = 1f;

    public float spawnTime = 2f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= spawnTime)
        {
            SpawnBlocks();
            spawnTime = Time.time + timeBetweenWaves;
        }
    }
    void SpawnBlocks()
    {

        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {

            if (randomIndex != i)
            {
                Instantiate(block, spawnPoints[i].position, Quaternion.identity);
            }
        }


    }
}
    