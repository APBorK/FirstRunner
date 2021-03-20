using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScene : MonoBehaviour
{
    //Скрипт отвечает за спавн сцены
    public GameObject scene;
    public Transform spawn;


    private void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Player"))
        {
            Spawn();
            ++SpeedController.SpawnCount;
        }
    }

    void Spawn()
    {
        Vector3 spawnPos = new Vector3(spawn.position.x, spawn.position.y,
            spawn.position.z + Memory.NextPositionScene);
        Instantiate(scene, spawnPos, Quaternion.identity);
    }
}