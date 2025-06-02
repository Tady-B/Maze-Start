using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    private string TeachScene = "TeachScene";
    //游戏开始的场景转换
    public void GameStartButtonClick()//按下之后转换场景到教程关卡
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
