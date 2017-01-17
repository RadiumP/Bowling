using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pins : MonoBehaviour {
    //no nested prefabs in unity: prefab has multiple gameobjects from another prefab is not linked to it anymore

    public float angleThreshold = 5f;
   
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public bool IsStanding()
    {
        //Mathf.Abs(Mathf.DeltaAngle(transform.rotation.eulerAngles.x, 0)); // Calculates the shortest difference between two given angles given in degrees.
        Vector3 currentAngle = transform.rotation.eulerAngles;
        if (Mathf.Abs(Mathf.DeltaAngle(currentAngle.x, 0)) < angleThreshold && Mathf.Abs(Mathf.DeltaAngle(currentAngle.z, 0)) < angleThreshold)
        {
            return true;
        }
        else
        {
            Debug.Log(Mathf.Abs(currentAngle.x));
            return false;
        }

        //return true;
    }
}
