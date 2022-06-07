using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenuButtonControl : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;
    public GameObject Menu3;
    public GameObject Menu4;
    public GameObject Text;

    private static int MainMenuStartButton = 0;
    void Start()
    {
        if (MainMenuStartButton != 0)
        {
            DestroyObject();
        }


    }

    public void DestroyObject()
    {
        GameObject.Find("MainMenuCanvas").transform.Find("DestroyButton").gameObject.SetActive(false);

        Menu1.SetActive(true);
        Menu2.SetActive(true);
        Menu3.SetActive(true);
        Menu4.SetActive(true);
        Text.SetActive(true);
    }
    public void NewStart()
    {
        Menu1.SetActive(false);
        Menu2.SetActive(false);
        Menu3.SetActive(false);
        Menu4.SetActive(false);
        Text.SetActive(false);
        MainMenuStartButton++;
        SceneManager.LoadScene("NewStart");
    }

    public void LoadStart()
    {
        Menu1.SetActive(false);
        Menu2.SetActive(false);
        Menu3.SetActive(false);
        Menu4.SetActive(false);
        Text.SetActive(false);
        MainMenuStartButton++;
        SceneManager.LoadScene("LoadStart");
    }

    public void Setting()
    {
        // 옵션 온오프
    }

    public void Exit()
    {
        // 종료
    }
}
