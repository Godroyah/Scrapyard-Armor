
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2TargetController : MonoBehaviour {

	// Use this for initialization

	void Awake ()
	{
		Cursor.visible = false;
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.Find ("T1Target").transform.position = new Vector3 (mousePosition.x, mousePosition.y, transform.Find ("T1Target").transform.position.z);
	}
}
