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

    void Spawn(){
        for(int i=0;i<30;i++){
            Instantiate(prefab,new Vector2(-10+0.7f*i,20),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeToNextSpawn-=Time.deltaTime;
        if(timeToNextSpawn <= 0.0f){
            Spawn();            
            timeToNextSpawn=timeBetweenSpawns;
        }
        
    }
}
