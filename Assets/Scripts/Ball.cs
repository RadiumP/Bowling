using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 speed;
    public bool isLaunched = false;
   

    private Vector3 startPosition;
    private AudioSource audioSource;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

       
        rb.useGravity = false;

        startPosition = transform.position;
        //Launch(speed);
        
	}
	
	

    public void Launch(Vector3 velocity)
    {
        isLaunched = true;
       
        rb.velocity = velocity;
        rb.useGravity = true;
       
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void Reset()
    {
        transform.position = startPosition;
        rb.velocity =  Vector3.zero;
        rb.angularVelocity = Vector3.zero;//no rotation
        rb.useGravity = false;
        isLaunched = false;
    }

}
