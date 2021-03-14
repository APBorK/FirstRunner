using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionСheck : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Car"))
        {
            ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
