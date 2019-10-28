using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1ColliderIgnoreChassis : MonoBehaviour {


	public GameObject T1Turret;
	public GameObject T1ArmorFront;
	public GameObject T1ArmorSide;
	public GameObject T1ArmorRear;
	public GameObject T1Object;
	//public GameObject T1EmptObject;
	private Vector3 childLocalposition;
	private Quaternion childLocalrotation;

	// Use this for initialization
	void Start () 
	{
		childLocalposition = this.transform.localPosition;
		childLocalrotation = this.transform.localRotation;

		Physics2D.IgnoreCollision (T1Turret.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorFront.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorSide.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorRear.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1Object.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T1EmptObject.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}
	
	// Update is called once per frame
	void Update () {
		
		Physics2D.IgnoreCollision (T1Turret.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorFront.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorSide.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorRear.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1Object.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T1EmptObject.GetComponent<Collider2D> (), GetComponent<Collider2D> ());

		this.transform.localPosition = childLocalposition;
		this.transform.localRotation = childLocalrotation;

	}
}
