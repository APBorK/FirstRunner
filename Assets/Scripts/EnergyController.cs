using UnityEngine;

public class EnergyController : MonoBehaviour
{
    
    public GameObject player;
    public static float Energy ;

    private void Start()
    {
        Energy = 1000;
         
    }
    

    private void Update()
    {
        Energy -= Time.deltaTime;
    }

}
