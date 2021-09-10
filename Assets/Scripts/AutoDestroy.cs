using UnityEngine;
using UnityEngine.Serialization;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField]
    private float lifeTime;        

    void Start() 
    {
        Destroy(gameObject, lifeTime);
    }

}
