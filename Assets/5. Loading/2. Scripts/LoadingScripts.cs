using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScripts : MonoBehaviour
{
	// 유저인터페이스를 연결하기 위한 변수
	// public GameObject playrUi; // 왜 유지시켜줘야하나
	//로딩(설명)Panel을 연결 하기위한 배열
	public GameObject LoadingMain;
	public GameObject LoadingBar;
	public GameObject[] exPnl;
	//로딩 progress Text 컴포넌트를 연결하기 위한 변수 
	//public Text progressText;

    // Start is called before the first frame update
    // 순서를 지켜 주자 그래야 코딩도 편해지고 성능이 안좋은 플랫폼에서 문제 발생을 방지.
    void Start()
    {        
		// 로딩(설명)Panel 렌덤으로 선택
		exPnl [Random.Range (0, 2)].SetActive (true);  // 1
		// playrUi.SetActive (true);  
        StartCoroutine (this.Loading());
    }

	//유니티엔진에게 역할을 분담시켜 유니티엔진에 렌더링 루프와 별도로 처리되어 성능향상 .
	IEnumerator Loading(){
		// 1초 정도는 화면에 설명을 뛰워주자 바로 게임으로 넘어가면 이상함 
		yield return new WaitForSeconds(1.0f);

		AsyncOperation async;


		GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;


		if (Portal.SceneNum == 5)
        {
			if (Portal.PotalNum == 1)
			{
				async = SceneManager.LoadSceneAsync("Map1", LoadSceneMode.Additive);
				GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(111.313f, 1.834176f, 27.24719f);
			}

			else
			{
				async = SceneManager.LoadSceneAsync("Map2", LoadSceneMode.Additive);
				GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(228.3002f, 1.182065f, 71.38586f);
			}
		}

		else if (Portal.SceneNum == 6)
        {
			if (Portal.PotalNum == 1)
			{
				async = SceneManager.LoadSceneAsync("Map_City", LoadSceneMode.Additive);
				GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(60.88f, 5.092718f, 120.58f);
			}

			else
			{
				async = SceneManager.LoadSceneAsync("Map2", LoadSceneMode.Additive);
				GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(144.6f, 0.2600501f, 120.46f);
			}
		}

		else if (Portal.SceneNum == 7)
		{
			if (Portal.PotalNum == 1)
			{
				async = SceneManager.LoadSceneAsync("Map_City", LoadSceneMode.Additive);
				GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(135.9472f, 0.09294939f, 132.6703f);
			}

			else
			{
				async = SceneManager.LoadSceneAsync("Map1", LoadSceneMode.Additive);
				GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-13.79f, 0.3676873f, 103.01f);
			}
		}
		else
        {
			async = SceneManager.LoadSceneAsync("Map_City", LoadSceneMode.Additive);
			GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(56.02756f, 5.093f, 98.97034f);
		}



		//While 문으로 로딩진행사항을 표시해주자 
		//현재 로딩중일때 
		while (!async.isDone)
		{
			// async.progress 값은 0~1 값이다 따라서 100을 곱해주자 그래야 % 값 얻음. 
			float progress = async.progress * 100.0f;
			LoadingBar.GetComponent<Image>().fillAmount = (progress / 100.0f);
			LoadingBar.GetComponentInChildren<Text>().text = "Loading... " + progress.ToString() + "%";

			//  Mathf.RoundToInt는 float를 받아서 올림해서 인트형으로 반환 
			int pRounded = Mathf.RoundToInt(progress);
			//Text 컴포넌트에 text 요소를 다음과 같이 셋팅 
			//progressText.text = "Loading..." + pRounded.ToString() + "%";
			//  한프레임동안 대기한후 무한루프를 다시 수행한다
			//  IEnumerator문을 바로 탈출하려면 yield break문을 사용하면 된다.
			yield return true;
		}


		LoadingBar.GetComponentInChildren<Text>().text = "Loading... 100%";
		LoadingBar.GetComponent<Image>().fillAmount = 1f;


		GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().constraints = ~(RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationY);
		GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>().isTrigger = false;
		GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("JoyStick").gameObject.SetActive(true);

		yield return new WaitForSeconds(3.0f);


		// 로딩 완료후 설명서 비활성화 사운드 Ui 활성화 
		exPnl [0].transform.parent.gameObject.SetActive (false);
		LoadingBar.GetComponentInChildren<Text>().text = "";
		LoadingBar.GetComponent<Image>().fillAmount = 0f;
		LoadingMain.SetActive(false);

		if (Portal.SceneNum == 5)
		{
			if (Portal.PotalNum == 1)
			{
				SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map1"));
			}

			else
			{
				SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map2"));
			}
		}

		else if (Portal.SceneNum == 6)
		{
			if (Portal.PotalNum == 1)
			{
				SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map_City"));
			}

			else
			{
				SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map2"));
			}
		}

		else if (Portal.SceneNum == 7)
		{
			if (Portal.PotalNum == 1)
			{
				SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map_City"));
			}

			else
			{
				SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map1"));
			}
		}
		else
		{
			SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map_City"));
		}

		//GameObject.Find ("SoundCanvas").GetComponent<Canvas> ().enabled = true;
	}
}