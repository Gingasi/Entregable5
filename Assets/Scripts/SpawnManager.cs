using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Obstacle;
    public Vector3 spawnPosition = new Vector3(0, 0, 30);
   
    void Start()
    {
        InvokeRepeating("Obstacleprefab", 0.5f, 2f); //cada cuanto tiempo haremos que aparezca
    }
    //A continuación indicamos que se cree de la "nada" un obstaculo con las medidas de abajo
    public Vector3 RandomPosition()
    {
        float randomy = Random.Range(-10, 10);
        return new Vector3(0, randomy, spawnPosition.z + 50);
    }
    //indicamos a que distancia queremos que aparezca el objeto
    public void Obstacleprefab()
    {
        Instantiate(Obstacle, spawnPosition, Obstacle.transform.rotation);
        spawnPosition = RandomPosition();
    }

}
