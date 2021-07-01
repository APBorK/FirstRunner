using UnityEngine;
using UnityEngine.Serialization;

public class Energy : MonoBehaviour
{
    [SerializeField]
    private GameObject energy;

    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EnergyController.Energy += 50;
            ++MovePlayer.Speed;
            Destroy(energy);
        }
    }
}
