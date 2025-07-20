using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Slider CanvasSlider ;

    private float health = 2;

    public void Start()
    {
        rb.linearVelocity = transform.forward * 4;
        RotateSliderTowardsCamera();
        UpdatedSlider();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Player2 player2))
        {
            player2.TakeDamge();
            Destroy(gameObject);
        }
    }

    public void RotateSliderTowardsCamera()
    {
        CanvasSlider.transform.rotation = Quaternion.LookRotation(Vector3.down, Vector3.forward);
    }

    public void TakeDamge()
    {
        health--;
        if(health <= 0)
        {
            UIManager.Instance.AddScore();
            Destroy(gameObject);
        }
        UpdatedSlider();
    }

    private void UpdatedSlider()
    {
        CanvasSlider.value = health / 2f;
    }


}

