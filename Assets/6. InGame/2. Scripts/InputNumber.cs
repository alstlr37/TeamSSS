using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNumber : MonoBehaviour
{
    private bool activated = false;

    [SerializeField]
    private GameObject Block;

    [SerializeField]
    private Text text_Preview;

    [SerializeField]
    private Text text_Input;

    [SerializeField]
    private InputField if_text;

    [SerializeField]
    private GameObject ItemCount;
    

    void Awake()
    {
        Block = GameObject.Find("Inventory").transform.Find("InputNumber").transform.Find("Block").gameObject;
        ItemCount = GameObject.Find("Inventory").transform.Find("InputNumber").transform.Find("ItemCount").gameObject;
        text_Preview = GameObject.Find("Inventory").transform.Find("InputNumber").transform.Find("ItemCount").
            transform.Find("InputField").transform.Find("Placeholder").GetComponent<Text>();
        text_Input = GameObject.Find("Inventory").transform.Find("InputNumber").transform.Find("ItemCount").
            transform.Find("InputField").transform.Find("Text").GetComponent<Text>();
        if_text = GameObject.Find("Inventory").transform.Find("InputNumber").transform.Find("ItemCount").
            transform.Find("InputField").GetComponent<InputField>();
    }


    void Update()
    {
        if (activated)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                OK();
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cancel();
            }
        }
    }

    public void Call()
    {
        Block.SetActive(true);
        ItemCount.SetActive(true);
        activated = true;
        if_text.text = "";
        text_Preview.text = DragSlot.instance.dragSlot.itemCount.ToString();
    }

    public void Cancel()
    {
        activated = false;
        DragSlot.instance.SetColor(0);
        ItemCount.SetActive(false);
        Block.SetActive(false);
        DragSlot.instance.dragSlot = null;
    }

    public void OK()
    {
        DragSlot.instance.SetColor(0);

        int num;
        if (text_Input.text != "")
        {
            if(CheckNumber(text_Input.text))
            {
                num = int.Parse(text_Input.text);
                if (num > DragSlot.instance.dragSlot.itemCount)
                {
                    num = DragSlot.instance.dragSlot.itemCount;
                }
            }
            else
            {
                num = 1;
            }
        }
        else
        {
            num = int.Parse(text_Preview.text);
        }

        StartCoroutine(DropItemCorountine(num));
    }


    IEnumerator DropItemCorountine(int _num)
    {
        for(int i = 0; i < _num; i++)
        {
            DragSlot.instance.dragSlot.SetSlotCount(-1);
            yield return new WaitForSeconds(0.05f);
        }
        DragSlot.instance.dragSlot = null;
        ItemCount.SetActive(false);
        Block.SetActive(false);
        activated = false;
    }

    private bool CheckNumber(string _argString)
    {
        char[] _tempCharArray = _argString.ToCharArray();
        bool isNumber = true;

        for (int i = 0; i < _tempCharArray.Length; i++)
        {
            if(_tempCharArray[i] >= 48 && _tempCharArray[i] <= 57)
            {
                continue;
            }

            isNumber = false;
        }
        return isNumber;
    }
}
