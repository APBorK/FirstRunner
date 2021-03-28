using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Класс отвечает за передвижение камеры к игроку
    public GameObject player;
    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + _offset;
        }
        
    }
}