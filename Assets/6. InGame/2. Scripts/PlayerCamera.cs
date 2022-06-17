using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player;

    void Awake()
    {
        player = transform.parent.GetComponentInChildren<PlayerController>().gameObject;
        // 같은 부모안에서의 오브젝트 찾기
    }
    private void Update()
    {
        this.transform.position = player.transform.position;
    }
}
