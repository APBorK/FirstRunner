using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class  ColliderCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            Destroy(_gameObject);
        }
        
        if (other.gameObject.CompareTag("Energ"))
        {
            Destroy(_gameObject);
        }
    }
}
