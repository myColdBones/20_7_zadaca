using UnityEngine;

public class XD2 : MonoBehaviour
{
    public static XD2 Instance;
    public ZadEnum ZadEnum;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
}
