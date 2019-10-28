using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1CameraController : MonoBehaviour {

	public GameObject tank1;

    private T1Mobility t1HealthScript;

	private Vector3 offset;

	public Camera OrthographicCamera;

	public int camMaxOut;

	public int camMaxIn;

	public float CamChange;
	private float nextCam;


	// Use this for initialization
	void Start () {
        t1HealthScript = tank1.GetComponent<T1Mobility>();

		offset = transform.position - tank1.transform.position;

	}

	void Update ()
	{		
		if (Input.GetButton ("T1CamZoomIn") && OrthographicCamera.orthographicSize > camMaxIn && Time.time > nextCam) 
			{
				OrthographicCamera.orthographicSize -= 1;
				nextCam = Time.time + CamChange;
			} 
		else if (Input.GetButton ("T1CamZoomOut") && OrthographicCamera.orthographicSize < camMaxOut && Time.time > nextCam) 
			{
				OrthographicCamera.orthographicSize += 1;
				nextCam = Time.time + CamChange;
			}
	}
	// Update is called once per frame
	void LateUpdate () 
    {
        if (t1HealthScript.health > 0)
        {
            transform.position = tank1.transform.position + offset;
        }
	}
}
