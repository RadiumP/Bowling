using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PinSetter : MonoBehaviour {

    public int lastStanding = -1;
    public Text StandingPins;
    public float raiseDist = 40f;

    private Ball ball;
    private float lastCheckTime;
    private bool ballEntered = false;

	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        StandingPins.text = CountStanding().ToString();
        if (ballEntered)
        {            
            CheckStanding();
        }
       
	}

    public void RaisePins()
    {
        Debug.Log("Raise");
        foreach (Pins pin in FindObjectsOfType<Pins>())
        {
            //if (pin.IsStanding())
            {
                pin.Raise();
            }
            
        }
    }

    public void LowerPins()
    {
        Debug.Log("Lower");
        foreach (Pins pin in FindObjectsOfType<Pins>())
        {
            //if (pin.IsStanding())
            {
                pin.Lower();
            }

        }
    }
    public void RenewPins()
    {
        Debug.Log("Renew");
    }


    void CheckStanding()
    {
        if(lastStanding != CountStanding())
        {
            lastCheckTime = Time.time;
            lastStanding = CountStanding();
        }
        if (Time.time - lastCheckTime > 3f)
        {
            PinsHaveSettled();
        }

    }

    void PinsHaveSettled()
    {
        lastStanding = -1;
        ballEntered = false;
        StandingPins.color = Color.green;
        ball.Reset();
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
