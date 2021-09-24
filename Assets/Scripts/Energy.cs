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
        private float _addEnergy;
        
    }
}
