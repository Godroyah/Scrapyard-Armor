using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1TargetingLine : MonoBehaviour 
{
	public LineRenderer T1targetLine;
	private int laserCount;
	public float laserWait;
	private float nextLaser;

	// Use this for initialization
	void Start () 
	{
		T1targetLine = gameObject.GetComponent<LineRenderer> ();
		laserCount = 0;
        T1targetLine.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("T1TargetLaser") && Time.time > nextLaser)
		{
			nextLaser = Time.time + laserWait;
			laserCount += 1;
		}
		if (laserCount % 2 == 1) 
		{
			T1targetLine.enabled = true;
		}
		if (laserCount % 2 == 0) 
		{
			T1targetLine.enabled = false;
		}
	}
}
