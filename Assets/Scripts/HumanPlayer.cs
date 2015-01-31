using UnityEngine;
using System.Collections;

public class HumanPlayer : Player {

	public GameObject inputPad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(inputPad.GetComponent<InputPad>().dragging)
		{
			paddle.GetComponent<Paddle>().Move(inputPad.GetComponent<InputPad>().target);
		}
	}
}
