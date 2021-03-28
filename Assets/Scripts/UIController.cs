using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject player;
    public GameObject restartLevel;
    public GameObject gameOver;
    public Text energy;
    public Text record;
    private float _recordValue;

    private void Update()
    {
        if (player == null)
        {
            gameOver.SetActive(true);
            restartLevel.SetActive(true);
        }
        _recordValue += Time.deltaTime;
        record.text = "Record: " + (int) _recordValue;
        EnergyController.Energy -= Time.deltaTime;
        energy.text = "Energy: " + (int) EnergyController.Energy;
    }
    
}
