using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ShellIgnore : MonoBehaviour {

	public GameObject T2Shell;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Physics2D.IgnoreCollision (T2Shell.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}
}
