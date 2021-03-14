using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveBot : MonoBehaviour
{
    //Скрипт отвечает за приследование Player

    public static float speed;
    public float firstLinePosition,
        laneDistance,
        sideSpeed;
    
    private Vector3 _moveVector;
    private int _trafficLineNumber = 1;
    private CharacterController _movingSpace;


    void Start()
    {
        speed = 10;
        _movingSpace = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        _moveVector.z = speed;
        _moveVector *= Time.deltaTime;

        _moveVector.x = MovePlayer._moveVector.x;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Lerp(newPosition.x, firstLinePosition + (_trafficLineNumber * laneDistance),
            Time.deltaTime * sideSpeed);
        transform.position = newPosition;
        _movingSpace.Move(_moveVector);
    }
}
