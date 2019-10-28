using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1GunBlast : MonoBehaviour {

	public Animator gunBlasting;

    public GameObject T1Tank;

    private T1Mobility t1ShootScript;

	public float roF; //rate of fire
	public float nextShell;

	void Start () 
    {
       t1ShootScript = T1Tank.GetComponent<T1Mobility>();
        gunBlasting = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
		if (Input.GetButton("Fire1") && Time.time > nextShell)
        {
			nextShell = Time.time + roF;
            gunBlasting.SetBool("Firing", true);
        }
        else
        {
            gunBlasting.SetBool("Firing", false);
        }
	}
}
