using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyController : MonoBehaviour
{
    
    public GameObject Player;
    public float _energy ;

    private void Start()
    {
        _energy = 1000;
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _energy += 500;
        }
    }

    private void Update()
    { 
       --_energy;
        if (_energy == 0)
        {
            Destroy(Player);
        }
    }
    
    void OnGUI()
    {
        GUI.Box(new Rect(0, 28, 100, 30), "Energy = " + _energy );
    }
    
}
