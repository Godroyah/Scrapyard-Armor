using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T1SideArmorReader : MonoBehaviour {

	public GameObject T1SideArmor;
	public Text SideArmorText;

	private T1SideChassisArmor t1sidearmorScript; 

	// Use this for initialization
	void Start () 
	{
		t1sidearmorScript = T1SideArmor.GetComponent<T1SideChassisArmor> ();
		SideArmorText = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () 
	{
		SideArmorText.text = ("Flank Armor: " + t1sidearmorScript.Armor_Value);
	}
}

