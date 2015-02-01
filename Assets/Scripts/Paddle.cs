using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	private float xLocation;
	private float maxMoveSpeed;

	// Use this for initialization
	void Start () {
		maxMoveSpeed = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {

	}

	float XLocation {
		get {
			return Camera.main.WorldToScreenPoint(transform.position).x;
		}
		set {
			xLocation = value;
		}
	}

	float MaxMoveSpeed {
		get {
			return WorldToScreenMagnitude(maxMoveSpeed);
		}
		set {
			maxMoveSpeed = value;
		}
	}

	public void Move(float location)
	{
		if(Mathf.Abs(location - XLocation) <= MaxMoveSpeed)
		{
			Vector3 targetSpot = Camera.main.ScreenToWorldPoint(new Vector3(location, 0, 0));
			transform.position = new Vector3(targetSpot.x, transform.position.y, 0);
		}
		else if(location > XLocation)
		{
			transform.position += new Vector3(Mathf.Clamp((location - XLocation), 0, MaxMoveSpeed*Time.deltaTime), 0, 0);
		}
		else if(location < XLocation)
		{
			transform.position -= new Vector3(Mathf.Clamp((XLocation - location), 0, MaxMoveSpeed*Time.deltaTime), 0, 0);
		}
	}

	private float WorldToScreenMagnitude(float point)
	{
		float screenPoint = Camera.main.WorldToScreenPoint(new Vector3(point, 0, 0)).x;
		float zeroPoint = Camera.main.WorldToScreenPoint(new Vector3(0, 0, 0)).x;
		return Mathf.Abs(screenPoint - zeroPoint);
	}
}
