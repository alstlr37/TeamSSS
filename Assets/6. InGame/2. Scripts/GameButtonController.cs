using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButtonController : MonoBehaviour
{
    public static GameButtonController instance;

    public GameObject player;
    public GameObject foot;

    private bool Jumping;
    RaycastHit hitInfo;
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

        player = GameObject.FindGameObjectWithTag("Player");
        foot = GameObject.FindGameObjectWithTag("foot");
    }

    public void Jump()
    {
        if(Jumping == true)
        {
            player.GetComponentInChildren<Rigidbody>().AddForce(new Vector3(0f, 1000f, 0f));
        }
    }

    void Update()
    {
        Ray ray = new Ray(foot.transform.position, new Vector3(0f, -1f, 0f));
        
        if (Physics.Raycast(ray, out hitInfo, 0.1f))
        {
            Jumping = true;
        }
        else
        {
            Jumping = false;
        }
    }
}
