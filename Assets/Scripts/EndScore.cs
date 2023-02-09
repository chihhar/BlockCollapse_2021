using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    //�X�R�A�\��
    public Text ScoreText;
    //�n�C�X�R�A�\��
    public Text highScoreText;

    //�X�R�A
    private int Score;
    //�n�C�X�R�A
    private int highScore;

    //PlayerPrefs�ŕۑ����邽�߂̃L�[
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
