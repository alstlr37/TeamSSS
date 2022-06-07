using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LogoManager : MonoBehaviour
{
    public GameObject BG;
    public GameObject MainMenuCanvas;
    public GameObject SoundManager;
    public GameObject MainMenuButtonControl;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DelayTime", 3.0f);
    }

    IEnumerator DelayTime(float a)
    {
        yield return new WaitForSeconds(a);

        DontDestroyOnLoad(BG);

        MainMenuCanvas.SetActive(true);
        SoundManager.SetActive(true);
        MainMenuButtonControl.SetActive(true);
        DontDestroyOnLoad(MainMenuCanvas);
        DontDestroyOnLoad(SoundManager);
        DontDestroyOnLoad(MainMenuButtonControl);
        SceneManager.LoadScene("MainMenu");
    }
}
