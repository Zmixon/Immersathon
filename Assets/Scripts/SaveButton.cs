﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour {
    public BeatRecorder recorder;
    // Use this for initialization
    void Start () {
        Debug.Log(recorder);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        recorder.SaveMusic();
        Rigidbody rigid = gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(new Vector3(-70, 120, 0));
        rigid.AddTorque(new Vector3(20, 0, 20));
        rigid.useGravity = true;
    }
}
