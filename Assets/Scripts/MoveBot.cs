using UnityEngine;

/// <summary>
/// Скрипт отвечает за приследование Player
/// </summary>
public class MoveBot : MoveController
{
    public float SpeedBot
    {
        get => _speed;
        set => _speed = value;
    }
    private Vector3 _moveVector;
    private CharacterController _movingSpace;

    void Start()
    {
        _movingSpace = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move(_moveVector,Input.GetAxis("Horizontal") * sideSpeed,_speed,_movingSpace);
    }
}