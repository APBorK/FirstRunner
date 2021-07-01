using UnityEngine;
using UnityEngine.Serialization;

public class FlashingLight : MonoBehaviour
{
    [FormerlySerializedAs("redlight")] [SerializeField]
    private GameObject _redlight;
    [FormerlySerializedAs("bluelight")] [SerializeField]
    private GameObject _bluelight;
    
    private float _timer = 2;

    private void Start()
    {
        _bluelight.SetActive(false);
    }

    void Update() 
    {
        _timer -= Time.deltaTime;
        if (_timer < 1)
        {
            _redlight.SetActive(false);
            _bluelight.SetActive(true);

        }
        
        if (_timer < 0 ) 
        {
            _redlight.SetActive(true);
            _bluelight.SetActive(false);
            _timer = 2;
               
        }

        

    }
}
