using UnityEngine;
using UnityEngine.Serialization;

public class GameOver : MonoBehaviour
{
    // Класс отвечает за проигрышь при низкой скорости и столкновение с ботом
    [FormerlySerializedAs("player")] [SerializeField]
    private GameObject _player;

    void Update()
    {
        if (EnergyController.Energy == 0)
        {
            Destroy(_player);
        }
        
        if (MovePlayer.Speed == 0)
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