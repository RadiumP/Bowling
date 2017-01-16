using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pins : MonoBehaviour {
    //no nested prefabs in unity: prefab has multiple gameobjects from another prefab is not linked to it anymore

    public float angleThreshold;
   
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        //IsStanding();
	}

    public bool IsStanding()
    {
        Vector3 currentAngle = transform.rotation.eulerAngles;
        if (Mathf.Abs(currentAngle.x) < angleThreshold && Mathf.Abs(currentAngle.z) < angleThreshold)
        {
            return true;
        }
        else
        {
            Debug.Log("Fall");
            return false;
        }

        //return true;
    }
}
