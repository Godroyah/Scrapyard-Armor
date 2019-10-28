using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour {

	public GameObject Screen1;
	public GameObject Screen2;
	public GameObject Screen3;
	public GameObject Screen4;
	public GameObject Player1;
	public GameObject Player2;

	private AudioSource menuMusic;

	private float waitNext;
	public float waitTime;

	// Use this for initialization
	void Start () {

		menuMusic = GetComponent<AudioSource> ();
		menuMusic.Play ();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Screen1.activeSelf && (Input.GetButton ("Player1") || Input.GetButton ("Player2")) && Time.time > waitNext) 
		{
			waitNext = Time.time + waitTime;
			Screen1.SetActive(false);
			Screen2.SetActive(true);
		}
		else if (Screen2.activeSelf && (Input.GetButton ("Player1") || Input.GetButton ("Player2")) && Time.time > waitNext)
		{
			waitNext = Time.time + waitTime;
			Screen2.SetActive(false);
			Screen3.SetActive(true);
		}
		else if (Screen3.activeSelf && (Input.GetButton ("Player1") || Input.GetButton ("Player2")) && Time.time > waitNext)
		{
			waitNext = Time.time + waitTime;
			Screen3.SetActive(false);
			Screen4.SetActive(true);
		}
		else if (Screen4.activeSelf && (Input.GetButton ("Player1")) && Time.time > waitNext)
		{
			waitNext = Time.time + waitTime;
			Screen4.SetActive(false);
			Player1.SetActive(true);
		}
		else if (Screen4.activeSelf && (Input.GetButton ("Player2")) && Time.time > waitNext)
		{
			waitNext = Time.time + waitTime;
			Screen4.SetActive(false);
			Player2.SetActive(true);
		}
		else if (Player1.activeSelf && (Input.GetButton ("Player2")) && Time.time > waitNext)
		{
			waitNext = Time.time + waitTime;
			SceneManager.LoadScene ("ScrapyardArmor");
		}
		else if (Player2.activeSelf && (Input.GetButton ("Player1")) && Time.time > waitNext)
		{
			waitNext = Time.time + waitTime;
			SceneManager.LoadScene ("ScrapyardArmor");
		}
		else if (Input.GetButton ("Quit"))
		{
			Application.Quit();
		}
	}
}
