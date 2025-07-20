using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class xd : MonoBehaviour
{
    

    public void Zad1ButtonPressed()
    {
        XD2.Instance.ZadEnum = ZadEnum.Zad1;
        LoadScene();
    }
    public void Zad2ButtonPressed()
    {
        XD2.Instance.ZadEnum = ZadEnum.Zad2;
        LoadScene();
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("Zad1_2");
    }

}
public enum ZadEnum
{
    None,
    Zad1,
    Zad2
}
