using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T1FrontalArmorReader : MonoBehaviour {


	public GameObject T1FrontalArmor;
	public Text FrontArmorText;

	private T1FrontChassisArmor t1frontarmorScript; 

	// Use this for initialization
	void Start () 
	{
		t1frontarmorScript = T1FrontalArmor.GetComponent<T1FrontChassisArmor> ();
		FrontArmorText = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		FrontArmorText.text = ("Frontal Armor: " + t1frontarmorScript.Armor_Value);
	}
}
