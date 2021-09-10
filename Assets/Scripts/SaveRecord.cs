using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveRecord
{
    public static void Save(float recordValue, float record)
    {
        if (record < recordValue)
        {
            PlayerPrefs.SetFloat("Point", recordValue);
        }
    }

    public static void Load(float oldRecord, TextMeshProUGUI record)
    {
        oldRecord = PlayerPrefs.GetFloat("Point");
        record.text ="Record: " + (int) PlayerPrefs.GetFloat("Point");
    }
}
