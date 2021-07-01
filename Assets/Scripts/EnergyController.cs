using System;
using UnityEngine;

public class EnergyController : MonoBehaviour
{
    public static float Energy
    {
        get => _energy ;
        set => _energy = value;
    }
    
    private static float _energy;

    private void Start()
    {
        _energy = 100;
    }

    private void Update()
    {
        _energy -= Time.deltaTime;
    }

}
