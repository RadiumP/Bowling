using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 speed;
    private AudioSource audioSource;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();

        Launch();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Launch()
    {
        rb.velocity = speed;
        audioSource.Play();
    }

}
