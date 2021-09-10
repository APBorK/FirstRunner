using UnityEngine;
/// <summary>
/// Класс отвечает за движение Player
/// </summary>
public class MovePlayer : MoveController
{
    public static float SpeedPlayer
    {
        get => _speed;
        set => _speed = value;
    }
    
    private static float _speed;
    private Vector3 _moveVector;
    private CharacterController _movingSpace;
    void Start()
    {
        _speed = 10;
        _movingSpace = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move(_moveVector, Input.GetAxis("Horizontal") * sideSpeed, _speed,_movingSpace);
    }
}