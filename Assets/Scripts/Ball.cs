using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		velocity = Vector3.up * 10;
		rigidbody2D.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		rigidbody2D.velocity = Vector3.Reflect(velocity, collision.contacts[0].normal);
		velocity = rigidbody2D.velocity;
	}
}
