using UnityEngine;
using UnityEngine.Serialization;

public class FlashingLight : MonoBehaviour
{
    [FormerlySerializedAs("redlight")] [SerializeField]
    private GameObject _redlight;

    [FormerlySerializedAs("bluelight")] [SerializeField]
    private GameObject _bluelight;
    
    [SerializeField]
    private float _mainLightTimer;
    
    private float _lightTimer;

    private void Start()
    {
        _lightTimer = _mainLightTimer;
        if (_mainLightTimer % 2 > 0)
        {
            _redlight.SetActive(false);
        }
        if (_mainLightTimer % 2 == 0 ) 
        {
            _bluelight.SetActive(false);
        }
    }

    void Update()
    {
        _lightTimer -= Time.deltaTime;
        int integer = (int) _lightTimer;
        if (integer % 2 != 0)
        {
            _redlight.SetActive(false);
            _bluelight.SetActive(true);

        }
        if (integer % 2 == 0 ) 
        {
            _redlight.SetActive(true);
            _bluelight.SetActive(false);
        }

        if (_lightTimer == 0)
        {
            _lightTimer = _mainLightTimer;
        }
    }
}
