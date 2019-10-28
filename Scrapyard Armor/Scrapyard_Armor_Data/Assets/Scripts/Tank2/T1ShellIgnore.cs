using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1ShellIgnore : MonoBehaviour {

	public GameObject T1Shell;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Physics2D.IgnoreCollision (T1Shell.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}
}
