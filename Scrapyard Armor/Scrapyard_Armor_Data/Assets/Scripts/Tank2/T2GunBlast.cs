using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2GunBlast : MonoBehaviour {

    public Animator gunBlasting;

    public GameObject T2Tank;

    private T2Mobility t2ShootScript;

    void Start()
    {
        t2ShootScript = T2Tank.GetComponent<T2Mobility>();
        gunBlasting = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2") && Time.time > t2ShootScript.nextShell)
        {
            gunBlasting.SetBool("Firing", true);
        }
        else
        {
            gunBlasting.SetBool("Firing", false);
        }
    }
}
