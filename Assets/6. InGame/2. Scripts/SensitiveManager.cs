using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SensitiveManager : MonoBehaviour
{
    public float SensitiveValue = 1.0f;
    public Slider sl;
    public GameObject Sensitive;
    private VirtualJoyStick Joy;

    public static SensitiveManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Joy = GetComponent<VirtualJoyStick>();
        }
        else
        {
            Destroy(gameObject);
        }

        sl = GameObject.Find("InGameCanvas").transform.Find("objSensitive").transform.Find("slSensitive").gameObject.GetComponent<Slider>();
        Sensitive = GameObject.Find("InGameCanvas").transform.Find("objSensitive").gameObject;


    }
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        SensitiveValue = sl.value;
        JoySet();
        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetSensitive()
    {
        SensitiveValue = sl.value;
        JoySet();
    }

    void JoySet()
    {
        Joy.sensitivity = SensitiveValue;
    }

    public void SensitiveUiClose()
    {
        Sensitive.SetActive(false);
        //PlaySoundBtn.SetActive(open);
        SaveData();

        if (SceneManager.GetActiveScene().buildIndex > 4)
        {
            GameObject.FindGameObjectWithTag("Options").transform.Find("Menu").gameObject.SetActive(true);
        }
    }

    public void SaveData()
    {
        PlayerPrefs.SetFloat("SENSITIVEVALUE", SensitiveValue);
    }

    public void LoadData()
    {
        sl.value = PlayerPrefs.GetFloat("SENSITIVEVALUE");

        int isSave = PlayerPrefs.GetInt("ISSAVE");
        if (isSave == 0)
        {
            sl.value = 1.0f;
            SaveData();
            PlayerPrefs.SetInt("ISSAVE", 1);
        }
    }
}
