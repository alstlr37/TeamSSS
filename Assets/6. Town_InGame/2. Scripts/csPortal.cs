using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class csPortal : MonoBehaviour
{
    Transform tr;
    Vector3 pos;
    GameObject player;
    void Start()
    {
        tr = GetComponent<Transform>(); 
    }  
    private void OnTriggerEnter(Collider other)
    { 
        if(tr.parent.tag == "Portal_Map1" && other.tag =="Player")
        { 
            SceneManager.LoadScene("Map1");
            //pos = this.gameObject.transform.position;
            //other.transform.position = pos;
            //Debug.Log(pos);
        }

        else if (tr.parent.tag == "Portal_Map2" && other.tag == "Player")
        { 
            SceneManager.LoadScene("Map2");
        }


        else if (tr.parent.tag == "Portal_City" && other.tag == "Player")
        { 
            SceneManager.LoadScene("Map_City");
        }
    }

}
