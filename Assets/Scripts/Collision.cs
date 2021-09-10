using UnityEngine;
using UnityEngine.Serialization;
/// <summary>
/// Класс отвечает за столкновение с объектом
/// </summary>
public class Collision : MonoBehaviour
{
    [FormerlySerializedAs("car")] [SerializeField]
    private GameObject _car;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(_car);
            ++MoveBot.SpeedBot;
            --MovePlayer.SpeedPlayer;
        }
        
        if (other.gameObject.CompareTag("Bot"))
        {
            Destroy(_car);
        }
    }
}
