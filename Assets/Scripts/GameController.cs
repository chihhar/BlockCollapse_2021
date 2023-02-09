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
            // オブジェクトをアクティブにする
            ClearUI.SetActive(true);
            // クリア時にBallを消滅する
            GameObject obj = GameObject.Find("Ball");
            Destroy(obj);

            FindObjectOfType<Score>().Save();
        }
        // Ballが無くなり、かつBlockが残っている時にゲームオーバーとなる条件
        if (count1 == 0 && count != 0)
        {
            gamefinishflag = 1;
            //GameOverUIをアクティブにする
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