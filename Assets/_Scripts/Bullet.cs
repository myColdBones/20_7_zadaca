using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private float ttl = 2;

    private void Update()
    {
        MoveForward();
        SelfDestruct();
    }

    private void MoveForward()
    {
        rb.linearVelocity = transform.forward * 8;
    }

    private void SelfDestruct()
    {
        ttl -= Time.deltaTime;

        if (ttl <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamge();
            Destroy(gameObject);
        }
    }
}
