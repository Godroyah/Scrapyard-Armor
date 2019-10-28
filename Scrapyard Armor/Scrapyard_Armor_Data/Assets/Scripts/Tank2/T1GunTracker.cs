using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1GunTracker : MonoBehaviour {

	public Transform T1Gun;
	public float rotSpeed;
	public Quaternion trackerRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var T1GunPosition = T1Gun.position;
		Quaternion rot = Quaternion.LookRotation (transform.position - T1GunPosition, Vector3.forward);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotSpeed * Time.deltaTime);
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		trackerRotation = transform.rotation;
	}
}
