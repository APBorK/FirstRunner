using System;
using UnityEngine;
/// <summary>
/// Класс отвечает за движение Player
/// </summary>
public class MovePlayer : MoveController
{
    public float EnergyPoint
    {
        get => _energy;
        set => _energy = value;
    }
    [SerializeField]
    private float _energy;

    [SerializeField] private Energy _addEnergy;
    [SerializeField] 
    private MoveBot _moveBot;
    private Vector3 _moveVector;
    private CharacterController _movingSpace;
    void Start()
    {
        _movingSpace = GetComponent<CharacterController>();
    }

    void Update()
    {
        _energy -= Time.deltaTime;
        Move(_moveVector, Input.GetAxis("Horizontal") * sideSpeed, _speed,_movingSpace);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            --_speed;
            ++_moveBot.SpeedBot;
        }
        if (other.gameObject.CompareTag("SpawnScene"))
        {
            ++_speed;
        }
        if (other.gameObject.CompareTag("Energ"))
        {
            _energy += _addEnergy.AddEnergy;
        }
    }
}