using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float timeBetweenSpawns;
    public GameObject prefab;

    private float timeToNextSpawn;

    void Start()
    {
        timeToNextSpawn=timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        timeToNextSpawn-=Time.deltaTime;
        if(timeToNextSpawn <= 0.0f){
            
            Debug.Log("Time is up!!!");
            timeToNextSpawn=timeBetweenSpawns;
        }
        
    }
}
