using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2TargetingLine : MonoBehaviour 
{
	public LineRenderer T2targetLine;
	private int laserCount;
	public float laserWait;
	private float nextLaser;

	// Use this for initialization
	void Start () 
	{
		T2targetLine = gameObject.GetComponent<LineRenderer> ();
		laserCount = 0;
		T2targetLine.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("T2TargetLaser") && Time.time > nextLaser)
		{
			nextLaser = Time.time + laserWait;
			laserCount += 1;
		}
		if (laserCount % 2 == 1) 
		{
			T2targetLine.enabled = true;
		}
		if (laserCount % 2 == 0) 
		{
			T2targetLine.enabled = false;
		}
	}
}
