using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T1HealthText : MonoBehaviour {

	public GameObject T1Tank;
	public Text healthRecordText;

	private T1Mobility t1healthScript;

	// Use this for initialization
	void Start () 
	{
		t1healthScript = T1Tank.GetComponent<T1Mobility> ();
		healthRecordText = GetComponent<Text> (); 
	}
	
	// Update is called once per frame
	void Update () {
		healthRecordText.text = ("Health: " + t1healthScript.health);
	}
}
