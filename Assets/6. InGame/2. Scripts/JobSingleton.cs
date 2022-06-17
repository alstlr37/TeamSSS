using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobSingleton : MonoBehaviour
{
    public static JobSingleton instance;

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
    }
}
