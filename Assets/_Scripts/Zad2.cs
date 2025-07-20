using UnityEngine;

public class Zad2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (XD2.Instance.ZadEnum != ZadEnum.Zad2)
            gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
