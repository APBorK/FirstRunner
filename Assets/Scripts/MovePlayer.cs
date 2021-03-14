using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MovePlayer : MonoBehaviour
{
    //summery
    // Класс отвечает за движение Player
    
    public static float speed;
    public float firstLinePosition,
        laneDistance,
        sideSpeed;

    public static Vector3 _moveVector;
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

        _moveVector.x = Input.GetAxis("Horizontal") * sideSpeed;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Lerp(newPosition.x, firstLinePosition + (_trafficLineNumber * laneDistance),
            Time.deltaTime * sideSpeed);
        transform.position = newPosition;
        _movingSpace.Move(_moveVector);
    }
}
