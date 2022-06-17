using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public static int SceneNum;
    public static int PotalNum;


    void Start()
    {     

    }
    void OnTriggerEnter(Collider other)
    {
        
        if (this.tag == "Potal1" && other.tag == "Player")
        {
            SceneNum = SceneManager.GetActiveScene().buildIndex;
            PotalNum = 1;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            GameObject.FindGameObjectWithTag("InGameCanvas").transform.Find("InGame_Ui").Find("JoyStick").GetComponent<VirtualJoyStick>().inputDirection = Vector2.zero;
            GameObject.Find("JoyStick").transform.Find("Lever").GetComponent<RectTransform>().position = new Vector3(295.0f, 261.6f, 0.0f);
            GameObject.Find("JoyStick").SetActive(false);
            SceneManager.LoadScene("LoadingScene");
        }

        else if (this.tag == "Potal2" && other.tag == "Player")
        {
            SceneNum = SceneManager.GetActiveScene().buildIndex;
            PotalNum = 2;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            GameObject.FindGameObjectWithTag("InGameCanvas").transform.Find("InGame_Ui").Find("JoyStick").GetComponent<VirtualJoyStick>().inputDirection = Vector2.zero;
            GameObject.Find("JoyStick").transform.Find("Lever").GetComponent<RectTransform>().position = new Vector3(295.0f, 261.6f, 0.0f);
            GameObject.Find("JoyStick").SetActive(false);
            SceneManager.LoadScene("LoadingScene");
        }
    }    
}
