using UnityEngine;
using System.Collections;

public class ComputerPlayer : Player {

	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if(inputPad.GetComponent<InputPad>().dragging)
//		{
//			paddle.GetComponent<Paddle>().Move(inputPad.GetComponent<InputPad>().target);
//		}

		paddle.GetComponent<Paddle>().Move(Camera.main.WorldToScreenPoint(ball.transform.position).x);
	}
}
