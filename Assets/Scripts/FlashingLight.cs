using UnityEngine;

public class FlashingLight : MonoBehaviour
{
    public GameObject redlight;
    public GameObject bluelight;
    private float _timer = 2;

    private void Start()
    {
        bluelight.SetActive(false);
    }

    void Update() 
    {
        _timer -= Time.deltaTime;
        if (_timer < 1)
        {
            redlight.SetActive(false);
            bluelight.SetActive(true);

        }
        
        if (_timer < 0 ) 
        {
            redlight.SetActive(true);
            bluelight.SetActive(false);
            _timer = 2;
               
        }

        

    }
}
