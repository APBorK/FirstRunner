using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Класс отвечает за проигрышь при низкой скорости и столкновение с ботом
    public GameObject Player;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (MovePlayer.Speed == 0)
        {
            Destroy(Player);
            RestartLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bot"))
        {
            Destroy(Player);
            RestartLevel();
        }
    }

    void RestartLevel()
    {
    }
    
}