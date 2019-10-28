using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ColliderIgnoreTurret : MonoBehaviour {

	public GameObject T2Chassis;
	public GameObject T2ArmorFront;
	public GameObject T2ArmorSide;
	public GameObject T2ArmorRear;
	public GameObject T2Object;
	//public GameObject T1EmptObject;


	// Use this for initialization
	void Start () 
	{

		Physics2D.IgnoreCollision (T2Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2ArmorFront.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2ArmorSide.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2ArmorRear.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2Object.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T1EmptObject.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}

	// Update is called once per frame
	void Update () {

		Physics2D.IgnoreCollision (T2Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2ArmorFront.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2ArmorSide.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2ArmorRear.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2Object.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T1EmptObject.GetComponent<Collider2D> (), GetComponent<Collider2D> ());

	}
}
