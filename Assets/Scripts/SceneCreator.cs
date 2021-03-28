 using UnityEngine;
using Random = UnityEngine.Random;

public class SceneCreator : MonoBehaviour
{
    //Скрипт отвечает за спавн сцены
    public GameObject[] scene;
    public Transform scenePosition;
    private int _distance = 100;
    

    private void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Player"))
        {
            CreatesScene();
            ++MovePlayer.speed;
        }
    }

 
    void CreatesScene()
    {
        Vector3 spawnPos = new Vector3(scenePosition.position.x, 
            scenePosition.position.y,scenePosition.position.z + _distance); 
        Instantiate(scene[RandomCreationScene()], spawnPos, Quaternion.identity);

    }
    
    
    
    private int RandomCreationScene()
    {
        return Random.Range(1, scene.Length);
    }

    
}