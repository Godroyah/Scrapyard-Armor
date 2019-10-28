using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

	// Use this for initialization

	public int T1Wins;
	public int T2Wins;




	public static Scoring instance;

	void Awake ()
	{
		if (instance == null) 
		{
			DontDestroyOnLoad (gameObject);
			instance = this;
		} 
		else if (instance != this) 
		{
			Destroy (gameObject);
		}
	}


	void Start () 
	{
		
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("Tiger Score: " + T1Wins);
		Debug.Log ("Sherman Score: " + T2Wins);
	}
}
