using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnScene : MonoBehaviour
{
    //Скрипт отвечает за спавн сцены
    public GameObject[] scene;
    public Transform scenePosition;
    private List<GameObject> sceneList = new List<GameObject>();
    private int maxScene;
    private int distance = 100;


    private void Start()
    {
        maxScene = scene.Length;
    }

    private void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Player"))
        {
            Spawn();
            ++SpeedController.SpawnCount;
        }
    }

    private void Update()
    {
        RemovingScene();
    }

    void Spawn()
    {
        GameObject newScene;
        Vector3 spawnPos = new Vector3(scenePosition.position.x, scenePosition.position.y,scenePosition.position.z + distance); 
        newScene = Instantiate(scene[RandomCreationScene()], spawnPos, Quaternion.identity);
        sceneList.Add(newScene);

    }
    
    private void RemovingScene()  
    {
        if (sceneList.Count > maxScene)
        {
            Destroy(sceneList[0].gameObject);
            sceneList.RemoveAt(0);
        }
    }
    
    
    private int RandomCreationScene()
    {
        return Random.Range(1, scene.Length);
    }

    
}