using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public Transform spawn;
    public GameObject[] objToSpawn;

    private float minX;
    private float minZ;
    private float maxX;
    private float maxZ;

    
    void Start()
    {
        minX = -1.8F + spawn.localScale.x / 2;
        minX = 9.6F - spawn.localScale.x / 2;
        
        minZ = spawn.position.z + spawn.localScale.z / 2;
        minZ = spawn.position.z - spawn.localScale.z / 2;
        for (int i = 0; i < 5; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX,maxX),spawn.position.y,Random.Range(minZ,maxZ));
            Instantiate(objToSpawn[i], spawnPos, Quaternion.identity);
        }
       
    }
    
    void Update()
    {

    }
}
