using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject restartLevel;
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private TextMeshProUGUI energy;
    [SerializeField]
    private TextMeshProUGUI record;
    [SerializeField]
    private TextMeshProUGUI point;
    private float _recordValue;
    private float _record;

    private void Start()
    {
        SaveRecord.Load(_record,record);
    }

    private void Update()
    {
        if (player == null)
        {
            gameOver.SetActive(true);
            restartLevel.SetActive(true);
        }
        if (player != null)
        {
            _recordValue += Time.deltaTime;
            point.text = "Point: " + (int) _recordValue;
            energy.text = "Energy: " + (int) Energy.EnergyPoint;
        }
        if (gameOver != null)
        {
            SaveRecord.Save(_recordValue,_record);
        }
    }

}
