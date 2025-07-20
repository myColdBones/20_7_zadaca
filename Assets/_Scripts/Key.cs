using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider _other)
    {
        if(_other.TryGetComponent(out Player _player))
        {
            _player.AcquireKey();
            Destroy(gameObject);
        }
    }
}
