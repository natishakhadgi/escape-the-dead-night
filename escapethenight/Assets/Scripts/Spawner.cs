using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    public GameObject stageManager;

    private float timeBtwnSpawn;
    private float minTime = 0.9f;
    private int rand;
    //stages
    private int vampireStage = 15;
    private int witchStage = 40;

    // INITIALLY timeBtwnSpawn = spawnTimeBtwnSpawn = startTimeBtwnSpawn
    // spawnTimeBtwnSpawn never changes
    private float spawnTimeBtwnSpawn;
    public float startTimeBtwnSpawn;
    public float decreaseTime;

    void Start(){
        spawnTimeBtwnSpawn = startTimeBtwnSpawn;
    }
    // Update is called once per frame
    void Update()
    {
        //reset time between spawn to default value at start of each stage
        
        //changing stage
        if (timeBtwnSpawn <= 0){
            //witch stage
            if (StageManager.score >= witchStage)
                rand = Random.Range(10, 14);
            //vampire stage
            else if (StageManager.score >= vampireStage)
                rand = Random.Range(4, 9);
            //bat stage
            else
                rand = Random.Range(0, 3);

        //spawn
        Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
        timeBtwnSpawn = startTimeBtwnSpawn;
        
        if (startTimeBtwnSpawn > minTime)
            startTimeBtwnSpawn -= decreaseTime;
        }
        else
            timeBtwnSpawn -= Time.deltaTime;
    }
}

