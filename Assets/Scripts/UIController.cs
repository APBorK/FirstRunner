using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
   

    private void Update()
    {
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 30), "Record = ");
    }
}
