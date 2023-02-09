using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //スコア表示
    public Text scoreText;
    //ハイスコア表示
    public Text highScoreText;
    //スコア
    private int score;
    //ハイスコア
    private int highScore;

    //PlayerPrefsで保存するためのキー
    private string highScoreKey = "highScore";
    //PlayerPrefsで今回のスコアを保存するキー
    private string ScoreKey = "currentScore";



    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if(highScore < score)
        {
            highScore = score;
        }

        //Textに代入
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }
    //
    private void Initialize()
    {
        score = 0;

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    //スコア加算関数
    public void AddPoint(int point)
    {
        score = score + point;
    }

    //PlayerPrefssの保存
    public void Save()
    {
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.Save();
        Initialize();
    }
}
