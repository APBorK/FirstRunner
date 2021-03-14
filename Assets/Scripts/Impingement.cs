using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impingement : MonoBehaviour
{
    public GameObject Car; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(Car);
            ++SpeedController.ImpingementCount;
        }
    }
}
