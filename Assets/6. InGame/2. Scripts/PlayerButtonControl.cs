using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButtonControl : MonoBehaviour
{
    public static PlayerButtonControl instance;
    public GameObject[] btn;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }


        btn[0] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Button_Ui").FindChild("Attack").gameObject;
        btn[1] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Button_Ui").FindChild("Skill1").gameObject;
        btn[2] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Button_Ui").FindChild("Skill2").gameObject;
        btn[3] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Button_Ui").FindChild("Skill3").gameObject;
        btn[4] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Button_Ui").FindChild("Skill4").gameObject;
        btn[5] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Button_Ui").FindChild("Posion").gameObject;
        btn[6] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Button_Ui").FindChild("Jump").gameObject;
        btn[7] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("OptionButton").FindChild("SetButton").gameObject;
        btn[8] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("OptionButton").FindChild("MiniMapButton").gameObject;
        btn[9] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("OptionButton").FindChild("InventoryButton").gameObject;
        btn[10] = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("OptionButton").FindChild("QuestButton").gameObject;

    }

    void Start()
    {
        foreach (GameObject B in btn)
        {
            // 딱 버튼만 클릭되게함
            B.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
