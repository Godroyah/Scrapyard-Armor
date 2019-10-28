using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2CameraController : MonoBehaviour {

	public GameObject tank2;

    private T2Mobility t2HealthScript;

	private Vector3 offset;

	public Camera OrthographicCamera;

	public int camMaxOut;

	public int camMaxIn;

	public float CamChange;
	private float nextCam;


	// Use this for initialization
	void Start () {
        t2HealthScript = tank2.GetComponent<T2Mobility>();

		offset = transform.position - tank2.transform.position;

	}

	void Update ()
	{		
		if (Input.GetButton ("T2CamZoomIn") && OrthographicCamera.orthographicSize > camMaxIn && Time.time > nextCam) 
		{
			OrthographicCamera.orthographicSize -= 1;
			nextCam = Time.time + CamChange;
		} 
		else if (Input.GetButton ("T2CamZoomOut") && OrthographicCamera.orthographicSize < camMaxOut && Time.time > nextCam) 
		{
			OrthographicCamera.orthographicSize += 1;
			nextCam = Time.time + CamChange;
		}
	}
	// Update is called once per frame
	void LateUpdate () 
    {
        if (t2HealthScript.health > 0)
        {
            transform.position = tank2.transform.position + offset;
        }
	}
}