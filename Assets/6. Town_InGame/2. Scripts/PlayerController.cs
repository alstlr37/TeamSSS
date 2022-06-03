﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Transform characterBody;
    [SerializeField]
    private Transform cameraArm;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //animator = characterBody.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //LookAround();
    }

    public void Move(Vector2 inputDirection)
    {
        Vector2 moveInput = inputDirection;
        bool isMove = moveInput.magnitude != 0;

        if (isMove)
        {
            Vector3 lookForward = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraArm.right.x, 0f, cameraArm.right.z).normalized;
            Vector3 moveDir = lookForward * moveInput.y + lookRight * moveInput.x;

            //characterBody.forward = lookForward;
            characterBody.forward = moveDir;
            transform.position += moveDir * Time.deltaTime * 5f;
        }
    }

    public void LookAround(Vector3 inputDirection)
    {
        Vector2 mouseDelta = inputDirection;
        Vector3 camAngle = cameraArm.rotation.eulerAngles;

        float x = camAngle.x - mouseDelta.y;

        if (x < 180f)
        {
            x = Mathf.Clamp(x, -1f, 50f);
        }
        else
        {
            x = Mathf.Clamp(x, 335f, 359f);
        }

        cameraArm.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.x, camAngle.z);
    }
}