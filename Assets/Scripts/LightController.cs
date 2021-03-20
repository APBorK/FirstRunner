using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject[] light;
    private float Timer = 1;
    private float Timer2 = 2;

    void Start()
    {
    }
    
    void Update() 
    {
        Timer2 -= Time.deltaTime;
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            light[0].SetActive(false);
            light[1].SetActive(true);
            Timer = 2;
        }
        if (Timer2 < 0)
        {
            light[0].SetActive(true);
            light[1].SetActive(false);
            Timer2 = 2; 
        }

    }
}
