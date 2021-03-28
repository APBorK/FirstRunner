using UnityEngine;

public class Collision : MonoBehaviour
{
    // Класс отвечает за столкновение с объектом
    public GameObject car;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(car);
            ++MoveBot.speed;
            --MovePlayer.speed;
        }
    }
}
