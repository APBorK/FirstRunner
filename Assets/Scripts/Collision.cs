using UnityEngine;
using UnityEngine.Serialization;

public class Collision : MonoBehaviour
{
    // Класс отвечает за столкновение с объектом
    [FormerlySerializedAs("car")] [SerializeField]
    private GameObject _car;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(_car);
            ++MoveBot.Speed;
            --MovePlayer.Speed;
        }
    }
}
