using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoadStartButtonControl : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Rendering_Warrior").transform.Find("A03").GetComponent<Animator>().SetBool("Click", false);
        // GameObject.Find("Rendering_Assassin").transform.Find("A03").GetComponent<Animator>().SetBool("Click",false);
        // GameObject.Find("Rendering_Wizard").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click", false);

        GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
    }

    public void Select()
    {
        SceneManager.LoadScene("LoadingScene");
        // 캐릭터 선택
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Select_Sit1()
    {
        // if( 데이터베이스가 존재하면 )
        // { 어쩌구 저쩌구 데이터베이스 연동하면 구현하기 }

        GameObject.Find("Rendering_Warrior").transform.Find("A03").GetComponent<Animator>().SetBool("Click",true);
        // GameObject.Find("Rendering_Assassin").transform.Find("A03").GetComponent<Animator>().SetBool("Click",false);
        // GameObject.Find("Rendering_Wizard").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",false);

        GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(true);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").Find("SelectParticle").gameObject.SetActive(false);
    }

    public void Select_Sit2()
    {
        GameObject.Find("Rendering_Warrior").transform.Find("A03").GetComponent<Animator>().SetBool("Click",false);
        // GameObject.Find("Rendering_Assassin").transform.Find("A03").GetComponent<Animator>().SetBool("Click",true);
        // GameObject.Find("Rendering_Wizard").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",false);

        GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(true);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").Find("SelectParticle").gameObject.SetActive(false);
    }

    public void Select_Sit3()
    {
        GameObject.Find("Rendering_Warrior").transform.Find("A03").GetComponent<Animator>().SetBool("Click",false);
        // GameObject.Find("Rendering_Assassin").transform.Find("A03").GetComponent<Animator>().SetBool("Click",false);
        // GameObject.Find("Rendering_Wizard").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",true);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",false);

        GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(true);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").Find("SelectParticle").gameObject.SetActive(false);
    }

    public void Select_Sit4()
    {
        GameObject.Find("Rendering_Warrior").transform.Find("A03").GetComponent<Animator>().SetBool("Click",false);
        // GameObject.Find("Rendering_Assassin").transform.Find("A03").GetComponent<Animator>().SetBool("Click",false);
        // GameObject.Find("Rendering_Wizard").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").GetComponent<Animator>().SetBool("Click",true);

        GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        //GameObject.Find("Rendering_Warrior").transform.Find("A03").Find("SelectParticle").gameObject.SetActive(false);
        GameObject.Find("Rendering_Gunner").transform.Find("Soldier_Animations_humanoid").Find("SelectParticle").gameObject.SetActive(true);
    }
}
