using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    private int a = 0;
    public GameObject ui;

    public GameObject OnOff_Ui;
    public GameObject OnOff_Inven;

    private static UiController instance;


    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            OnOff_Ui = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").gameObject;
            OnOff_Ui.SetActive(true);

            OnOff_Inven = GameObject.Find("Options").transform.Find("Inventory").gameObject;
            OnOff_Inven.SetActive(true);

            OnOff_Inven.SetActive(false);
            OnOff_Ui.SetActive(false);

            DontDestroyOnLoad(this.gameObject);
            // 인벤토리 한번 켯다 꺼줘야 동적할당이 되므로 강제로 켯다끔.
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    void Start()
    {
        ui = GameObject.Find("InGameCanvas").transform.FindChild("InGame_Ui").gameObject;
        //ui = gameObject.transform.parent.FindChild("Player_Ui").gameObject;
        StartCoroutine(this.LoadingEnd());
    }

    IEnumerator LoadingEnd()
    {
        yield return new WaitForSeconds(3.0f);
        ui.SetActive(true);
        GameObject.Find("SoundManager").GetComponent<SoundManager>().PlayBackgroundMap1();
    }


    void Update()
    {

    }
}
