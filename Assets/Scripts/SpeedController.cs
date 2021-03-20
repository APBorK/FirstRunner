using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    // Скрипт отвечает за скорость объектов
    public static int SpawnCount;
    public static int ImpingementCount;


    void Update()
    {
        if (SpawnCount == 1)
        {
            ++MovePlayer.Speed;
            SpawnCount = 0;
        }

        if (ImpingementCount == 1)
        {
            ++MoveBot.Speed;
            --MovePlayer.Speed;
            ImpingementCount = 0;
        }
    }
}