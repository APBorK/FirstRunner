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
    private Vector3[] _line0;
    private Vector3[] _line1;
    private Vector3[] _line2;


    void Start()
    {
        _line0 = new Vector3[4];
        _line1 = new Vector3[4];
        _line2 = new Vector3[4];
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
        for (int i = 0; i < _line0.Length; i++)
        {
            _line0[i] = GetRandomOffsetLine(-2, 0);
            if (i > 0)
            {
                if (Vector3.Distance(_line0[i - 1], _line0[i]) > 10)
                {
                    Instantiate(objToSpawn, _line0[i], Quaternion.identity);
                }
                else
                {
                    _line0[i] = GetRandomOffsetLine(-2, 0);
                    break;
                }
            }

            if (i == 0)
            {
                Instantiate(objToSpawn, _line0[i], Quaternion.identity);
            }
        }

        for (int i = 0; i < _line1.Length; i++)
        {
            _line1[i] = GetRandomOffsetLine(2, 5);
            if (i > 0)
            {
                if (Vector3.Distance(_line1[i - 1], _line1[i]) > 10)
                {
                    Instantiate(objToSpawn, _line1[i], Quaternion.identity);
                }
                else
                {
                    _line1[i] = GetRandomOffsetLine(2, 5);
                    break;
                }
            }

            if (i == 0)
            {
                Instantiate(objToSpawn, _line1[i], Quaternion.identity);
            }
        }

        for (int i = 0; i < _line2.Length; i++)
        {
            _line2[i] = GetRandomOffsetLine(7, 10);
            if (i > 0)
            {
                if (Vector3.Distance(_line2[i - 1], _line2[i]) > 10)
                {
                    Instantiate(objToSpawn, _line2[i], Quaternion.identity);
                }
                else
                {
                    _line2[i] = GetRandomOffsetLine(7, 10);
                    break;
                }
            }

            if (i == 0)
            {
                Instantiate(objToSpawn, _line2[i], Quaternion.identity);
            }
        }

        _line0 = new Vector3[4];
        _line1 = new Vector3[4];
        _line2 = new Vector3[4];
    }

    Vector3 GetRandomOffsetLine(float minX, float maxX)
    {
        return new Vector3(Random.Range(minX, maxX), spawn.position.y, Random.Range(-10 +
            Memory.NextPositionCar, 62 + Memory.NextPositionCar));
    }
}