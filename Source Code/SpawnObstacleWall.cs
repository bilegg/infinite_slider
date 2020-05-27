using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnObstacleWall : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnDistance;
    private float nextSpawnPoint;
    private bool timeToSpawn;

    private void spawnWall(float z,int rnd)
    {
        switch (rnd)
        {
            case 1:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x , obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                break;
            case 2:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                break;
            case 3:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                break;
            case 4:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                break;
            case 5:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 2, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 6, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z + 12), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z + 12), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 6, obstacle.transform.position.y, z + 18), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 2, obstacle.transform.position.y, z + 18), obstacle.transform.rotation);
                break;
            case 6:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 2, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 6, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z + 12), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z + 12), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 6, obstacle.transform.position.y, z + 18), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 2, obstacle.transform.position.y, z + 18), obstacle.transform.rotation);
                break;
            case 7:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z + 1), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 2, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 2, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 2, obstacle.transform.position.y, z + 8), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z + 8), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 2, obstacle.transform.position.y, z + 10), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z + 10), obstacle.transform.rotation);
                break;
            case 8:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z + 1), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 2, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 2, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 2, obstacle.transform.position.y, z + 8), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z + 8), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 2, obstacle.transform.position.y, z + 10), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z + 10), obstacle.transform.rotation);
                break;
            case 9:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 3, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 3, obstacle.transform.position.y, z + 2), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 3, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 3, obstacle.transform.position.y, z + 4), obstacle.transform.rotation);

                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 3, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 3, obstacle.transform.position.y, z + 6), obstacle.transform.rotation);
                break;
            case 10:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                break;
            case 11:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 8, obstacle.transform.position.y, z), obstacle.transform.rotation);
                break;
            case 12:
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x - 4, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, z), obstacle.transform.rotation);
                Instantiate(obstacle, new Vector3(obstacle.transform.position.x + 4, obstacle.transform.position.y, z), obstacle.transform.rotation);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnPoint = spawnDistance;
        timeToSpawn = false;

        System.Random rnd = new System.Random();
        int wallNumber = rnd.Next(1, 13);
        spawnWall(this.transform.position.z + spawnDistance, wallNumber);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > nextSpawnPoint) timeToSpawn = true;
           
        if (timeToSpawn)
        {
        System.Random rnd = new System.Random();
        int wallNumber = rnd.Next(1, 13);

        spawnWall(this.transform.position.z + spawnDistance, wallNumber);

        nextSpawnPoint += spawnDistance;

        timeToSpawn = false;
        }
    }
}
