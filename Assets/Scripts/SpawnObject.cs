using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{ 
    [SerializeField] 
    private Transform _spawn;

    [SerializeField] 
    private GameObject _car;
    
    [SerializeField] 
    private GameObject _energy;
    
    [SerializeField] 
    private int _spawnCar;
    
    [SerializeField] 
    private int _spawnEnergy;
    
    private float minX;
    private float minZ;
    private float maxX;
    private float maxZ;
    private Vector3 _spawnPos;

    void Start()
    {
        minX = -4F;
        maxX = 12F;

        minZ = _spawn.position.z + _spawn.localScale.z/2;
        maxZ = _spawn.position.z - _spawn.localScale.z/2;
        for (int i = 0; i < _spawnCar; i++)
        {
            _spawnPos = new Vector3(Random.Range(minX, maxX), 5, Random.Range(minZ, maxZ));
            Invoke("SpawnCar()",5);
            SpawnCar();
        }
        
        for (int i = 0; i < _spawnEnergy; i++)
        {
            _spawnPos = new Vector3(Random.Range(minX, maxX), 5, Random.Range(minZ, maxZ));
            Invoke("SpawnEnergy()",5);
            SpawnEnergy();
        }
    }

    private void SpawnCar()
    {
      Instantiate(_car, _spawnPos, Quaternion.identity);
    }
    
    private void SpawnEnergy()
    {
        Instantiate(_energy, _spawnPos, Quaternion.identity);
    }
}

