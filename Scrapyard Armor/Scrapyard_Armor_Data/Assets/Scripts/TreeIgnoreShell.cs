using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeIgnoreShell : MonoBehaviour {

	public GameObject T1Shell;
	public GameObject T2Shell;

	//private Collider2D t1Shell;
	//private Collider2D t2Shell;

	// Use this for initialization
	void Start () {
		//t1Shell = T1Shell.GetComponent<Collider2D>();
		//t2Shell = T2Shell.GetComponent<Collider2D>();
	}

	// Update is called once per frame
	void Update () 
	{
		Physics2D.IgnoreCollision(T1Shell.GetComponent<Collider2D>(), GetComponent<Collider2D>());
		Physics2D.IgnoreCollision(T2Shell.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}


}
