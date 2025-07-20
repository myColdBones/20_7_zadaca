using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasKey;

    [SerializeField] private float speed;

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 movement =  new Vector3 (horz, vert,0) * speed;
        transform.position += movement * Time.deltaTime;
    }

    public void AcquireKey()
    {
        hasKey = true;
    }
    

}
