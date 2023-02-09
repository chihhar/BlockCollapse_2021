using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject ClearUI;
    public GameObject GameOverUI;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Block").Length;
        int count1 = GameObject.FindGameObjectsWithTag("Player").Length;
        int gamefinishflag = 0;
        if (count == 0)
        {
            gamefinishflag = 1;
            // �I�u�W�F�N�g���A�N�e�B�u�ɂ���
            ClearUI.SetActive(true);
            // �N���A����Ball�����ł���
            GameObject obj = GameObject.Find("Ball");
            Destroy(obj);

            FindObjectOfType<Score>().Save();
        }
        // Ball�������Ȃ�A����Block���c���Ă��鎞�ɃQ�[���I�[�o�[�ƂȂ����
        if (count1 == 0 && count != 0)
        {
            gamefinishflag = 1;
            //GameOverUI���A�N�e�B�u�ɂ���
            GameOverUI.SetActive(true);
            FindObjectOfType<Score>().Save();
        }
        if(gamefinishflag == 1)
        {
            Invoke("ChangeScene", 2.0f);
        }
    }
    private void ChangeScene()
    {
        SceneManager.LoadScene("Ending");
    }
}