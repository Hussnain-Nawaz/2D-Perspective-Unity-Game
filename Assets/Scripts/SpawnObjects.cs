using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] animals;
    public float spawnRange=15;
    public float spawnPosZ=16;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjectsRandomly", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObjectsRandomly()
    {
        int index = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
        Instantiate(animals[index], spawnPos, animals[index].transform.rotation);
    }
}
