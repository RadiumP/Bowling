﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 speed;
    private AudioSource audioSource;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

       
        rb.useGravity = false;
        //Launch(speed);
        
	}
	
	

    public void Launch(Vector3 velocity)
    {
        rb.velocity = velocity;
        rb.useGravity = true;
       
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

}
