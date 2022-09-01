using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject enemy;
    public GameObject spawnpoint;
    
    int enemy_counter = 0;
   
	void Start ()
    {
        InvokeRepeating("EnemySpawn", 0, spawnTime); //call EnemySpawnFunc Every spawnTime seconds.
	}
    
    void EnemySpawn()
    {   
    Debug.Log("spawn");
        GameObject.Instantiate(enemy, spawnpoint.transform.position, Quaternion.identity);
    }

}
