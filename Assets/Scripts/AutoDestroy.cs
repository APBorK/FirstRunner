using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    private float _lifeTime = 20f;        

    void Start() 
    {
        Destroy(gameObject, _lifeTime);
    }

}
