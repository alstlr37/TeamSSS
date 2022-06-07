using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class NewStartButtonControl : MonoBehaviour
{
    public void Unit_Warrior()
    {
        GameObject.Find("Canvas").transform.Find("Warrior").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Assassin").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Wizard").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Gunner").gameObject.SetActive(false);
    }

    public void Unit_Assassin()
    {
        GameObject.Find("Canvas").transform.Find("Warrior").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Assassin").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Wizard").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Gunner").gameObject.SetActive(false);
    }

    public void Unit_Wizard()
    {
        GameObject.Find("Canvas").transform.Find("Warrior").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Assassin").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Wizard").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Gunner").gameObject.SetActive(false);
    }

    public void Unit_Gunner()
    {
        GameObject.Find("Canvas").transform.Find("Warrior").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Assassin").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Wizard").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Gunner").gameObject.SetActive(true);
    }

    public void Skill_1()
    {
        GameObject.FindGameObjectWithTag("Rendering").GetComponentInChildren<Animator>().SetTrigger("Skill1");
    }

    public void Skill_2()
    {
        GameObject.FindGameObjectWithTag("Rendering").GetComponentInChildren<Animator>().SetTrigger("Skill2");
    }

    public void Skill_3()
    {
        GameObject.FindGameObjectWithTag("Rendering").GetComponentInChildren<Animator>().SetTrigger("Skill3");
    }

    public void Skill_4()
    {
        GameObject.FindGameObjectWithTag("Rendering").GetComponentInChildren<Animator>().SetTrigger("Skill4");
    }

    public void Select()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().clip = null;
        SceneManager.LoadScene("LoadingScene");
    }

    public void Go_Back()
    {
        GameObject.Find("MainMenuCanvas").transform.Find("Menu1").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Menu2").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Menu3").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Menu4").gameObject.SetActive(true);
        GameObject.Find("MainMenuCanvas").transform.Find("Text").gameObject.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }
}
