using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionController : MonoBehaviour
{
    public static OptionController instance;

    void Awake()
    {
        if ( instance == null )
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }

    public void Menu()
    {
        GameObject.FindGameObjectWithTag("Options").transform.Find("Menu").gameObject.SetActive(true);
    }

    public void MenuBotton1()
    {
        GameObject.FindGameObjectWithTag("Options").transform.Find("Menu").gameObject.SetActive(false);
    }

    public void MenuBotton2()
    {
        // 데이터 저장
    }

    public void MenuButton3()
    {
        GameObject Sound = GameObject.Find("MainMenuCanvas");
        Sound.SetActive(false);
        Sound.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("objSound").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.SetAsLastSibling();

        GameObject.FindGameObjectWithTag("Options").transform.Find("Menu").gameObject.SetActive(false);
    }

    public void MenuButton4()
    {
        GameObject.Find("InGameCanvas").transform.Find("objSensitive").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.SetAsLastSibling();
        GameObject.FindGameObjectWithTag("Options").transform.Find("Menu").gameObject.SetActive(false);
    }

    public void MenuButton5()
    {
        // Ui 데이터 초기화 ( 모든 데이터 초기화 )

        GameObject.Find("InGame_Ui").SetActive(false);
        Destroy(GameObject.FindGameObjectWithTag("Job"));
        Destroy(GameObject.Find("Scene_Job_Info"));
        Destroy(GameObject.Find("OptionController"));
        Destroy(GameObject.Find("GameButtonManager"));
        Destroy(GameObject.Find("InGameCanvas"));
        Destroy(GameObject.Find("GameButtonController"));

        GameObject.Find("MainMenuCanvas").transform.Find("Menu1").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Menu2").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Menu3").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Menu4").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Text").gameObject.SetActive(true);

        GameObject.Find("SoundManager").GetComponent<SoundManager>().PlayBackgroundMenu();
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");

    }

    public void MenuButton6()
    {
        Application.Quit();
    }

    public void MiniMap()
    {
        GameObject.FindGameObjectWithTag("Options").transform.Find("MiniMap").gameObject.SetActive(true);
    }

    public void Inventory()
    {
        GameObject.FindGameObjectWithTag("Options").transform.Find("Inventory").gameObject.SetActive(true);
    }

    public void InventoryQuit()
    {
        GameObject.FindGameObjectWithTag("Options").transform.Find("Inventory").gameObject.SetActive(false);
    }

    public void Quest()
    {

    }

    public void CloseOption()
    {
        //this.transform.GetComponentInParent<CanvasRenderer>().gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("OptionChild").SetActive(false);
    }
}
