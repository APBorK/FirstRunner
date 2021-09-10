using System;
using UnityEngine;
using UnityEngine.Serialization;
/// <summary>
/// Класс отвечает за проигрышь при низкой скорости и столкновение с ботом
/// </summary>
public class GameOver : MonoBehaviour
{
    [FormerlySerializedAs("player")] [SerializeField]
    private GameObject _player;

    void Update()
    {
        if (Energy.EnergyPoint == 0)
        {
            Destroy(_player);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bot"))
        {
            Destroy(_player);
        }
    }
    
}