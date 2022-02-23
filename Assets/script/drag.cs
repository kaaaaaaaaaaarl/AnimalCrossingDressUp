using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour, IPointerDownHandler, IDragHandler  {
	private RectTransform transformLaug;
	public Canvas kanva;

	// Use this for initialization
	public void awake () {
		transformLaug = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	public void OnPointerDown (PointerEventData notikums) {
		Debug.Log ("ir!!!!");
	}
	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Objekts parvietots");
		transformLaug.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}
	public void OnbBeginDrag(PointerEventData notikums){
		Debug.Log ("sakas");
	}
	public void OnbEndDrag(PointerEventData notikums){
		Debug.Log ("beidzas");
	}
}
