using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField]
    protected float firstLinePosition,
        laneDistance,
        sideSpeed;
    
    protected int _trafficLineNumber = 1;

    protected void Move(Vector3 moveVector, float moveVectorObject, float speed,CharacterController movingSpace)
    {
        moveVector.z = speed;
        moveVector *= Time.deltaTime;

        moveVector.x = moveVectorObject;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Lerp(newPosition.x, firstLinePosition + (_trafficLineNumber * laneDistance),
            Time.deltaTime * sideSpeed);
        transform.position = newPosition;
        movingSpace.Move(moveVector);
    }
}
