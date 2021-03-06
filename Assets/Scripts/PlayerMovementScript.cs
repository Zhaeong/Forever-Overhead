﻿using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    public float speed = 3.0f;
    public float rotateSpeed = 3.0f;


    // Use this for initialization
    void Start () {

    }
    void FixedUpdate()
    {
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
