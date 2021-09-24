using UnityEngine;
using UnityEngine.Serialization;
/// <summary>
/// Класс отвечает за столкновение с объектом
/// </summary>
public class Collision : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(_gameObject);
        }
        
        if (other.gameObject.CompareTag("Bot"))
        {
            Destroy(_gameObject);
        }
        
        if (other.gameObject.CompareTag("Car"))
        {
            Destroy(_gameObject);
        }
        
        if (other.gameObject.CompareTag("Energ"))
        {
            Destroy(_gameObject);
        }
    }
}
