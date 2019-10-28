using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1TurRotator : MonoBehaviour 
{

	public float rotSpeed; //speed of turret rotation in degrees
	public Rigidbody2D turretRb2d;

	public GameObject T1Chassis;
	public GameObject T1ArmorFront;
	public GameObject T1ArmorSide;
	public GameObject T1ArmorRear;
	public GameObject T1Object;


	//public GameObject T1EmptObject;


	// Use this for initialization
	void Start () 
	{
		

		turretRb2d = GetComponent<Rigidbody2D> ();


		Physics2D.IgnoreCollision (T1Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorFront.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorSide.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorRear.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1Object.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T1EmptObject.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}
	
	// Update is called once per frame
	void Update () {
		
		Physics2D.IgnoreCollision (T1Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorFront.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorSide.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1ArmorRear.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1Object.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T1EmptObject.GetComponent<Collider2D> (), GetComponent<Collider2D> ());

	}

	void FixedUpdate ()
	{
		
		//var T1Target = GameObject.Find ("T1Reticule").transform.position;

		//Quaternion rot = Quaternion.LookRotation (transform.position - T1Target, Vector3.forward);
		var y = Input.GetAxis("T1TurretRotate") * Time.deltaTime * rotSpeed;

		transform.Rotate (0, 0, y);
		//transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotSpeed * Time.deltaTime);
		//transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);

	}
}
