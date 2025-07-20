using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    private void Start()
    {
    }
    void Update()
    {
        UIManager.Instance.Zad2();
        Rotate();
        Shoot();
    }
    public void Rotate()
    {
        float rotateDirection = 0;
        if (Input.GetKey(KeyCode.A))
        {
            rotateDirection -= 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotateDirection += 1f;
        }

        //xddddddddddddddddddddddddd, ovo smece gleda loklanu rotaciju? I dodaje na rotaciju
        //transform.Rotate(0, rotateDirection * Time.deltaTime * 10, 0);

        transform.rotation =Quaternion.Euler(0, transform.rotation.eulerAngles.y + rotateDirection * Time.deltaTime * 300, 0);
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabBullet, transform.position, transform.rotation);
        }
    }
    private float health = 2;

    public void TakeDamge()
    {
        health--;
        if (health <= 0)
        {
            UIManager.Instance.ShowGameOber();
            UIManager.Instance.SaveHighScoreIfPossible();
            Destroy(gameObject);
        }
        
    }


}
