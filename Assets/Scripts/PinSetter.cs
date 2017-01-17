using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PinSetter : MonoBehaviour {


    public Text StandingPins;
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

}
