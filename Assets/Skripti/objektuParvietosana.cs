using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class objektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private RectTransform transfLogs; 
	public Canvas kanva;

	void Start(){
		transfLogs = GetComponent<RectTransform> ();


	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisas kllikskis uz objekta!");
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Kreisas kllikskis uz objekta!");
	}

	public void OnDrag(PointerEventData notikums){
		transfLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag (PointerEventData notikums){
		Debug.Log ("Objekta vilkšana pārtraukta");
	}
}