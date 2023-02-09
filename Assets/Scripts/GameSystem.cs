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
	//�@�Q�[���I���{�^��������������s����
	public void EndGame()
	{
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;   // UnityEditor�̎��s���~���鏈��
#else
        Application.Quit();                                // �Q�[�����I�����鏈��
#endif
    }
    public void BackHome()
    {
        SceneManager.LoadScene("Title");
    }
}
