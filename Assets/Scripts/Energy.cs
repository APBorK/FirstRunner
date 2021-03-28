using UnityEngine;

public class Energy : MonoBehaviour
{
    public GameObject energy;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EnergyController.Energy += 500;
            Destroy(energy);
        }
    }
}
