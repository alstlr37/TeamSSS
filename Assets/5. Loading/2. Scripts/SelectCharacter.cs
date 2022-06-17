using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public static int Job_num;
    public GameObject[] Jobs;

    public static SelectCharacter instance;
    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            Job_num = (int)SelectJob.instance.currentCharacter;
            DontDestroyOnLoad(Instantiate(Jobs[Job_num], new Vector3(0, 0, 0), Quaternion.identity));
        }
        else
        {
            Destroy(this.gameObject);
        } 
    }
}
