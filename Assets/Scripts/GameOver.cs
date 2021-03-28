using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Класс отвечает за проигрышь при низкой скорости и столкновение с ботом
    public GameObject player;
    

    void Update()
    {
        if (EnergyController.Energy == 0)
        {
            Destroy(player);
        }
        
        if (MovePlayer.speed == 0)
        {
            Destroy(player);
            RestartLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bot"))
        {
            Destroy(player);
            RestartLevel();
        }
    }

    void RestartLevel()
    {
    }
    
}