using UnityEngine;


public class MoveBot : MonoBehaviour
{
    //Скрипт отвечает за приследование Player
    
    [SerializeField]
    private float firstLinePosition,
        laneDistance,
        sideSpeed;
    
    public static float Speed
    {
        get => _speed ;
        set => _speed = value;
    }

    private static float _speed;
    private Vector3 _moveVector;
    private int _trafficLineNumber = 1;
    private CharacterController _movingSpace;


    void Start()
    {
        _speed = 9;
        _movingSpace = GetComponent<CharacterController>();
    }

    void Update()
    {
        _moveVector.z = _speed;
        _moveVector *= Time.deltaTime;

        _moveVector.x = MovePlayer.MoveVector.x;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Lerp(newPosition.x, firstLinePosition + (_trafficLineNumber * laneDistance),
            Time.deltaTime * sideSpeed);
        transform.position = newPosition;
        _movingSpace.Move(_moveVector);
    }
}