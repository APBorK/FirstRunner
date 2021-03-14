using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEditor.SearchService;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnCar : MonoBehaviour
{
    //Скрипт отвечает за за создание позиции для спавна и размищение объектов по данным позициям
    public Transform spawn;
    public GameObject objToSpawn;
    private Vector3[] line0;
    private Vector3[] line1;
    private Vector3[] line2;





    void Start()
    {
        line0 = new Vector3[4]; 
        line1 = new Vector3[4]; 
        line2 = new Vector3[4]; 
    }

    private void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Player"))
        { 
            Spawn();
            Memory.NextPositionCar += 100;
        }
    }

 
   

    void Spawn()
    {

        for (int i = 0; i < line0.Length; i++)
        {
            line0[i] = GetRandomOffsetLine0();
            if (i>0)
            {
                if (Vector3.Distance(line0[i - 1], line0[i]) > 10)
                {
                    Instantiate(objToSpawn, line0[i], Quaternion.identity);
                    
                }
                else
                {
                    line0[i] = GetRandomOffsetLine0();
                    break;
                }
            }
            if(i == 0)
            {
                Instantiate(objToSpawn, line0[i], Quaternion.identity);
            }
            
            
        }
        
        for (int i = 0; i < line1.Length; i++)
        {
            line1[i] = GetRandomOffsetLine1();
            if (i>0)
            {
                if (Vector3.Distance(line1[i - 1], line1[i]) > 10)
                {
                    Instantiate(objToSpawn, line1[i], Quaternion.identity);
                    
                }
                else
                {
                    line1[i] = GetRandomOffsetLine1();
                    break;
                }
            }
            if(i == 0)
            {
                Instantiate(objToSpawn, line1[i], Quaternion.identity);
            }
        }
        
        for (int i = 0; i < line2.Length; i++)
        {
            line2[i] = GetRandomOffsetLine2();
            if (i>0)
            {
                if (Vector3.Distance(line2[i - 1], line2[i]) > 10)
                {
                    Instantiate(objToSpawn, line2[i], Quaternion.identity);
                    
                }
                else
                {
                    line2[i] = GetRandomOffsetLine2();
                    break;
                }
            }
            if(i == 0)
            {
                Instantiate(objToSpawn, line2[i], Quaternion.identity);
            }
            
            
        }
        line0 = new Vector3[4];
        line1 = new Vector3[4]; 
        line2 = new Vector3[4];
    }

    Vector3 GetRandomOffsetLine0()
    {
        return new Vector3(Random.Range(-2, 0), spawn.position.y, Random.Range(-10 + Memory.NextPositionCar, 62 + Memory.NextPositionCar));
    }
    Vector3 GetRandomOffsetLine1()
    {
        return new Vector3(Random.Range(2, 5), spawn.position.y, Random.Range(-10 + 
            Memory.NextPositionCar, 62 + Memory.NextPositionCar));
    }
    Vector3 GetRandomOffsetLine2()
    {
        return new Vector3(Random.Range(7, 10), spawn.position.y, Random.Range(-10 + 
            Memory.NextPositionCar, 62 + Memory.NextPositionCar));
    }

}
