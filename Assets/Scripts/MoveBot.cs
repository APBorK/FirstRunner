using UnityEngine;

/// <summary>
/// Скрипт отвечает за приследование Player
/// </summary>
public class MoveBot : MoveController
{
    public static float SpeedBot
    {
        get => _speed;
        set => _speed = value;
    }
    
    private Vector3 _moveVector;
    private static float _speed;
    private CharacterController _movingSpace;

    void Start()
    {
        _speed = 9;
        _movingSpace = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move(_moveVector,Input.GetAxis("Horizontal") * sideSpeed,_speed,_movingSpace);
    }
}