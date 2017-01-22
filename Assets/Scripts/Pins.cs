using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pins : MonoBehaviour {
    //no nested prefabs in unity: prefab has multiple gameobjects from another prefab is not linked to it anymore

    public float angleThreshold = 5f;
    public float raiseDist = 40f;

    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        
	}


    public void Raise()
    {
        Debug.Log("Raise");
       // foreach (Pins pin in FindObjectsOfType<Pins>())
        //{
            if (IsStanding())
            {
                transform.Translate(new Vector3(0, raiseDist, 0), Space.World);//space.world makes it work in global y
                rb.useGravity = false;
                
            }

        //}
    }

    public void Lower()
    {
        Debug.Log("Lower");
        // foreach (Pins pin in FindObjectsOfType<Pins>())
        //{
        if (IsStanding())
        {
            transform.Translate(new Vector3(0, -raiseDist, 0), Space.World);//space.world makes it work in global y
            rb.useGravity = true;
        }

        //}
    }


    public bool IsStanding()
    {
        //if g too high, will shake.
        //Mathf.Abs(Mathf.DeltaAngle(transform.rotation.eulerAngles.x, 0)); // Calculates the shortest difference between two given angles given in degrees.
        Vector3 currentAngle = transform.rotation.eulerAngles;
        if (Mathf.Abs(Mathf.DeltaAngle(currentAngle.x - 270f, 0)) < angleThreshold && Mathf.Abs(Mathf.DeltaAngle(currentAngle.z, 0)) < angleThreshold)
        {
            return true;
        }
        else
        {
            //Debug.Log(Mathf.Abs(Mathf.DeltaAngle(currentAngle.z, 0)));
            return false;
        }

        //return true;
    }
}
