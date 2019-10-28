using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T1RearArmorText : MonoBehaviour {

	public GameObject T1RearArmor;
	public Text RearArmorText;

	private T1RearChassisArmor t1reararmorScript; 

	// Use this for initialization
	void Start () 
	{
		t1reararmorScript = T1RearArmor.GetComponent<T1RearChassisArmor> ();
		RearArmorText = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () 
	{
		RearArmorText.text = ("Rear Armor: " + t1reararmorScript.Armor_Value);
	}
}