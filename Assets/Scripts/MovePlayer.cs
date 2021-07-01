using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Класс отвечает за движение Player
    
    [SerializeField]
    private float firstLinePosition,
        laneDistance,
        sideSpeed;

    public static float Speed
    {
        get => _speed ;
        set => _speed = value;
    }
    
    public static Vector3 MoveVector
    {
        get => _moveVector ;
        set => _moveVector = value;
    }

    private static float _speed;
    private static Vector3 _moveVector;
    private int _trafficLineNumber = 1;
    private CharacterController _movingSpace;


    void Start()
    {
        _speed = 10;
        _movingSpace = GetComponent<CharacterController>();
    }

    void Update()
    {
        _moveVector.z = _speed;
        _moveVector *= Time.deltaTime;

        _moveVector.x = Input.GetAxis("Horizontal") * sideSpeed;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Lerp(newPosition.x, firstLinePosition + (_trafficLineNumber * laneDistance),
            Time.deltaTime * sideSpeed);
        transform.position = newPosition;
        _movingSpace.Move(_moveVector);
    }
}