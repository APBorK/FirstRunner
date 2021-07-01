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
        Load();
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
            EnergyController.Energy -= Time.deltaTime;
            energy.text = "Energy: " + (int) EnergyController.Energy;
        }

        if (gameOver != null)
        {
            Save();
        }
    }

    private void Save()
    {
        if (_record < _recordValue)
        {
            PlayerPrefs.SetFloat("Point", _recordValue);
        }
    }

    private void Load()
    {
        _record = PlayerPrefs.GetFloat("Point");
        record.text ="Record: " + (int) PlayerPrefs.GetFloat("Point");
    }
    
}
