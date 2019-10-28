using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ShellMover : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed;
	public int Penetration;
	public int T2shellDamage = 10;

	// Use this for initialization
	void Start () 
	{

		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = transform.up * speed;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
