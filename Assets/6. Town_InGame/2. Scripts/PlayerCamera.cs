using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        this.transform.position = player.transform.position;
    }
}
