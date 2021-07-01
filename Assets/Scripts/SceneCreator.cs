 using UnityEngine;
 using UnityEngine.Serialization;
 using Random = UnityEngine.Random;

public class SceneCreator : MonoBehaviour
{
    //Скрипт отвечает за спавн сцены
    [FormerlySerializedAs("scene")] [SerializeField]
    private GameObject[] _scene;
    [FormerlySerializedAs("scenePosition")] [SerializeField]
    private Transform _scenePosition;
    private int _distance = 100;
    

    private void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Player"))
        {
            CreatesScene();
            ++MovePlayer.Speed;
        }
    }

 
    void CreatesScene()
    {
        var position = _scenePosition.position;
        Vector3 spawnPos = new Vector3(position.x, 
            position.y,position.z + _distance); 
        Instantiate(_scene[RandomCreationScene()], spawnPos, Quaternion.identity);

    }
    
    
    
    private int RandomCreationScene()
    {
        return Random.Range(1, _scene.Length);
    }

    
}