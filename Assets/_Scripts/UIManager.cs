using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] private GameObject PressEForDoorGameObject;
    [SerializeField] private TMP_Text scoreTMP;
    [SerializeField] private TMP_Text highscoreTMP;

    private int score;
    private int highscore;

    private const string highScore_Key = "key";

    public void Awake()
    {
        Instance = this;
        scoreTMP.gameObject.SetActive(false);
        highscoreTMP.gameObject.SetActive(false);
    }
    private void Start()
    {


        highscore = PlayerPrefs.GetInt(highScore_Key, 0);
        UpdateScores();
    }

    public void Zad2()
    {
        scoreTMP.gameObject.SetActive(true);
        highscoreTMP.gameObject.SetActive(true);
    }
    public void SetActivePressEForDoorGameObject(bool state)
    {
        PressEForDoorGameObject.SetActive(state);
    }

    public void UpdateScores()
    {
        scoreTMP.text = "Score:" + score;
        if(score > highscore)
        {
            highscore = score;
        }
        highscoreTMP.text = "Highscore:" + highscore;
    }

    public void SaveHighScoreIfPossible()
    {

            PlayerPrefs.SetInt(highScore_Key, highscore);
        
    }

    public void AddScore()
    {
        score++;
        UpdateScores();
    }
}
