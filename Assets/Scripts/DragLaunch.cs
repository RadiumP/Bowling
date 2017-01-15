using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]// require to have Ball
public class DragLaunch : MonoBehaviour {

    private Ball ball;
    private Vector3 speed;
    private float startTime;
    private Vector3 startPosition;
    private float endTime;
    private Vector3 endPosition;
   
    // Use this for initialization
    void Start () {
        ball = GetComponent<Ball>();
	}
    
    public void DragStart()
    {
        startTime = Time.time;
        startPosition = Input.mousePosition;
    }

    public void DragEnd()
    {
        endTime = Time.time;
        endPosition = Input.mousePosition;

        //care mouse drag direction 
        float speedx = (endPosition.x - startPosition.x) / (endTime - startTime);
        float speedz = (endPosition.y - startPosition.y) / (endTime - startTime);

        speed = new Vector3(speedx, 0, speedz);

       
        ball.Launch(speed);
       
    }


    public void MoveStart(float xNudge)
    {
        if(!ball.isLaunched) 
        {
            if(ball.transform.position.x + xNudge >= -43f && ball.transform.position.x + xNudge <= 43f)
            ball.transform.position += new Vector3(xNudge, 0, 0); 
        }

       
       
    }



}
