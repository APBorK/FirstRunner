using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Класс отвечает за передвижение камеры к игроку
    [SerializeField]
    private GameObject _player;
    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - _player.transform.position;
    }


    void LateUpdate()
    {
        if (_player != null)
        {
            transform.position = new Vector3(_player.transform.position.x, transform.position.y,_player.transform.position.z + 
            _offset.z) ;
        }
        
    }
}