using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent <Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector2 move = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		rb.MovePosition (rb.position+move*speed*Time.deltaTime);
	}
}
