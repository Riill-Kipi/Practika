using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform[] spawnPoint;

    public float rangeTimeStart;
    private float timeSpawn;
    private int rand;
    private int randPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeSpawn <= 0){
            rand = Random.Range(0, enemy.Length);
            randPosition = Random.Range(0, spawnPoint.Length);
            Instantiate(enemy[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
            timeSpawn = rangeTimeStart;
        }else{
            timeSpawn -= Time.deltaTime;
        }
    }
}
