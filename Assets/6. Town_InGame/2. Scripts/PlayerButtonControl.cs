using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButtonControl : MonoBehaviour
{
    public GameObject[] btn;
    // Start is called before the first frame update
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
