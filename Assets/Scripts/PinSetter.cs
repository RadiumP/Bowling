using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PinSetter : MonoBehaviour {


    public Text StandingPins;

    private bool ballEntered = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StandingPins.text = CountStanding().ToString();
	}

    int CountStanding()
    {
        int remains = 0;
        foreach(Pins pin in FindObjectsOfType<Pins>())
        {
            if(pin.IsStanding())
            {
                remains++;
            }
        }
        return remains;
    }

    void OnTriggerEnter(Collider col)
    {
        
        GameObject thingHit = col.gameObject;
        //ball enters
        if (thingHit.GetComponent<Ball>())
        {
            ballEntered = true;
            StandingPins.color = Color.red;
        }

    }

    void OnTriggerExit(Collider col)

    {
        GameObject thingExit = col.gameObject;
        //ball enters
        if (thingExit.GetComponent<Pins>())
        {
            Destroy(thingExit);
        }
    }



}
