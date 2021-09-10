 using UnityEngine;
 using UnityEngine.Serialization;
 using Random = UnityEngine.Random;
/// <summary>
/// Скрипт отвечает за спавн сцены
/// </summary>
public class SceneCreator : MonoBehaviour
{
    [FormerlySerializedAs("scene")] [SerializeField]
    private GameObject _scene;
    [FormerlySerializedAs("scenePosition")] [SerializeField]
    private Transform _scenePosition;
    private int _distance = 100;
    

    private void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Player"))
        {
            CreatesScene();
            ++MovePlayer.SpeedPlayer;
            ++MoveBot.SpeedBot;
        }
    }

 
    void CreatesScene()
    {
        var position = _scenePosition.position;
        Vector3 spawnPos = new Vector3(position.x, 
            position.y,position.z + _distance); 
        Instantiate(_scene, spawnPos, Quaternion.identity);

    }


}