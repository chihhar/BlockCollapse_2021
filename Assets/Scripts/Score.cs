using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //�X�R�A�\��
    public Text scoreText;
    //�n�C�X�R�A�\��
    public Text highScoreText;
    //�X�R�A
    private int score;
    //�n�C�X�R�A
    private int highScore;

    //PlayerPrefs�ŕۑ����邽�߂̃L�[
    private string highScoreKey = "highScore";
    //PlayerPrefs�ō���̃X�R�A��ۑ�����L�[
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

        //Text�ɑ��
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }
    //
    private void Initialize()
    {
        score = 0;

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    //�X�R�A���Z�֐�
    public void AddPoint(int point)
    {
        score = score + point;
    }

    //PlayerPrefss�̕ۑ�
    public void Save()
    {
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.Save();
        Initialize();
    }
}
