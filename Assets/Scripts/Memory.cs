using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour
{
    //Скрипт отвечает за вспомогательные значения 
    public static int NextPositionScene;
    public static int NextPositionCar;


    void Update()
    {
        NextPositionScene = 100;
    }
}