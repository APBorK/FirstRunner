using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Класс отвечает за движение Player

    public static float speed;

    public float firstLinePosition,
        laneDistance,
        sideSpeed;

    public static Vector3 MoveVector;
    private int _trafficLineNumber = 1;
    private CharacterController _movingSpace;


    void Start()
    {
        speed = 10;
        _movingSpace = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveVector.z = speed;
        MoveVector *= Time.deltaTime;

        MoveVector.x = Input.GetAxis("Horizontal") * sideSpeed;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Lerp(newPosition.x, firstLinePosition + (_trafficLineNumber * laneDistance),
            Time.deltaTime * sideSpeed);
        transform.position = newPosition;
        _movingSpace.Move(MoveVector);
    }
}