using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public static int SpawnCount;
    public static int ImpingementCount;
    private int speed;
    void Start()
    {
        speed = 10;

    }
    
    void Update()
    {
        if (SpawnCount == 1)
        {
            MoveBot.speed += speed;
            MovePlayer.speed += speed;
            SpawnCount = 0;
        }

        if (ImpingementCount == 1)
        {
            MovePlayer.speed -= speed;
            ImpingementCount = 0;
        }
    }
}
