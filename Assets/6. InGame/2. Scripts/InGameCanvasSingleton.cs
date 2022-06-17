using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCanvasSingleton : MonoBehaviour
{
    public static InGameCanvasSingleton instance;

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
