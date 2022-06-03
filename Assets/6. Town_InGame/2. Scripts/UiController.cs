using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.LoadingEnd());
    }

    IEnumerator LoadingEnd()
    {
        yield return new WaitForSeconds(3.0f);
        ui.SetActive(true);
    }
}
