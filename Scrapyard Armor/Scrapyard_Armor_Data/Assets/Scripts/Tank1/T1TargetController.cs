
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1TargetController : MonoBehaviour {

	// Use this for initialization

	public float cursorSpeed;
	private Rigidbody2D rb2d;

	void Awake ()
	{
		Cursor.visible = false;
	}

	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		var controlMousePosx = Input.GetAxis("Mouse X");
		var controlMousePosy = Input.GetAxis("Mouse Y");
		transform.Translate(controlMousePosx, controlMousePosy, rb2d.transform.position.z);
	}
}
