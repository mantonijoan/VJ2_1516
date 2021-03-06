﻿using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    public Camera camIso;
    public Camera camFirst;

    float _velocity = 10.0f;
    float _angularVelocity = 100.0f;

	// Use this for initialization
	void Start () {
        // By default activate camIso
        camIso.enabled = true;
        camFirst.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        float aZ = Input.GetAxis("Vertical") * Time.deltaTime * _velocity;

        float _rotFactor = Input.GetAxis("Vertical");
        float aR = Input.GetAxis("Horizontal") * Time.deltaTime * _angularVelocity * _rotFactor;
        
        transform.Translate(0.0f, 0.0f, aZ);
        transform.Rotate(0.0f, aR, 0.0f);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            camIso.enabled = true;
            camFirst.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            camIso.enabled = false;
            camFirst.enabled = true;
        }
    }
}
