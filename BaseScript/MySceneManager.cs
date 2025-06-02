using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    private string TeachScene = "TeachScene";
    //��Ϸ��ʼ�ĳ���ת��
    public void GameStartButtonClick()//����֮��ת���������̳̹ؿ�
    {
        LoadAsyncScene();
    }
    IEnumerator LoadAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("TeachScene");
        while (!asyncLoad.isDone)
        {
            yield return null;
            Debug.Log("asyncLoad haven't done!");
        }
       
    }

}
