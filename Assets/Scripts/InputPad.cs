using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class InputPad : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler {

	public bool dragging;
	public float target;

	// Use this for initialization
	void Start () {
		dragging = false;
		target = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerClick (PointerEventData eventData)
	{
		//not implemented
	}

	public void OnPointerDown (PointerEventData eventData)
	{
		dragging = true;
		target = eventData.position.x;
	}

	public void OnPointerUp (PointerEventData eventData)
	{
		dragging = false;
	}

	public void OnDrag (PointerEventData eventData)
	{
		target = eventData.position.x;
	}
}
