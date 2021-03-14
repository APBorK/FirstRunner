using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impingement : MonoBehaviour
{
    // Класс отвечает за столкновение с объектом
    public GameObject car;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(car);
            ++SpeedController.ImpingementCount;
        }
    }
}
