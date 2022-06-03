using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButtonController : MonoBehaviour
{
    public GameObject player;
    public GameObject foot;

    private bool Jumping;
    RaycastHit hitInfo;

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
