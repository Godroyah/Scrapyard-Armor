using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2TurRotator : MonoBehaviour 
{

	public float rotSpeed; //speed of turret rotation in degrees
	public Rigidbody2D turretRb2d;

	public Transform T1Gun;

	public GameObject T2Chassis;
	public GameObject T2ArmorFront;
	public GameObject T2ArmorSide;
	public GameObject T2ArmorRear;
	public GameObject T2Object;
	//public GameObject T1EmptObject;


	// Use this for initialization
	void Start () 
	{
		turretRb2d = GetComponent<Rigidbody2D> ();

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

	void FixedUpdate ()
	{
		//var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//var T1GunPosition = T1Gun.position;
		//Quaternion rot = Quaternion.LookRotation (transform.position - T1GunPosition, Vector3.forward);

		var y = Input.GetAxis("T2TurretRotate") * Time.deltaTime * rotSpeed;

		transform.Rotate (0, 0, y);

		//transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotSpeed * Time.deltaTime);
		//transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		//turretRb2d.angularVelocity = 0;
	}
}
