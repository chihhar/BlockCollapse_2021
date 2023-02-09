using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    //スコア表示
    public Text ScoreText;
    //ハイスコア表示
    public Text highScoreText;

    //スコア
    private int Score;
    //ハイスコア
    private int highScore;

    //PlayerPrefsで保存するためのキー
    private string highScoreKey = "highScore";
    private string scoreKey = "currentScore";

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        highScoreText.text = highScore.ToString();
        Score = PlayerPrefs.GetInt(scoreKey, 0);
        ScoreText.text = Score.ToString();
    }
}
