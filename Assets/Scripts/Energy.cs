using UnityEngine;

namespace System
{
    public class Energy : MonoBehaviour
    {
        public float AddEnergy
        {
            get => _addEnergy;
            set => _addEnergy = value;
        }
        [SerializeField]
        private GameObject _gameObject;
        [SerializeField] private float _addEnergy;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(_gameObject);
            }
        }
    }
}
