using UnityEngine;

namespace System
{
    public class Energy : MonoBehaviour
    {
        public static float EnergyPoint
        {
            get => _energy;
            set => _energy = value;
        }
        
        [SerializeField]
        private GameObject _gameObject;

        private static float _energy = 100;

        private void Update()
        {
            _energy -= Time.deltaTime;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _energy += 50;
                ++MovePlayer.SpeedPlayer;
                Destroy(_gameObject);
            }
        }
    }
}
