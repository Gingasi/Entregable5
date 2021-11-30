using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Obstacle;
    public Vector3 spawnPosition = new Vector3(0, 0, 30);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Obstacleprefab", 0.5f, 2f);
    }

    public Vector3 RandomPosition()
    {
        float randomy = Random.Range(-10, 10);
        return new Vector3(0, randomy, spawnPosition.z + 50);
    }
    public void Obstacleprefab()
    {
        Instantiate(Obstacle, spawnPosition, Obstacle.transform.rotation);
        spawnPosition = RandomPosition();
    }

}
