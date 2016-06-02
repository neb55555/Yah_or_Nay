using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

	public Text text;

	// Use this for initialization
	public void OnPointerEnter(PointerEventData e){
		text.color = Color.black;
	}
	public void OnPointerExit(PointerEventData e){
		text.color = Color.blue;
	}
}
