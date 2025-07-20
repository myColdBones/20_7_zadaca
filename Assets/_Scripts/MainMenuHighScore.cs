using TMPro;
using UnityEngine;

public class MainMenuHighScore : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreTMP;
    void Start()
    {
        ScoreTMP.text = "Highscore:" + PlayerPrefs.GetInt("key", 0);
    }
}
