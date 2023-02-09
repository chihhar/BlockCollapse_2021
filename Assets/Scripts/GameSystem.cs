using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Ending()
    {
        SceneManager.LoadScene("Ending");
    }
	//　ゲーム終了ボタンを押したら実行する
	public void EndGame()
	{
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;   // UnityEditorの実行を停止する処理
#else
        Application.Quit();                                // ゲームを終了する処理
#endif
    }
    public void BackHome()
    {
        SceneManager.LoadScene("Title");
    }
}
