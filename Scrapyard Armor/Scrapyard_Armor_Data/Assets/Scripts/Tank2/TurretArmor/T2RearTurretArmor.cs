using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2RearTurretArmor : MonoBehaviour {

	public GameObject T2Tank;
	public GameObject T1Shell;

	private T2Mobility T2moblityScript;
	private T1ShellMover T1penetrationScript;

	public int Armor_Value = 50;

	//public float hitAngle;
	//public float lineOfSightArmor;

	// Use this for initialization
	void Start () {

		T2moblityScript = T2Tank.GetComponent<T2Mobility> ();
		T1penetrationScript = T1Shell.GetComponent<T1ShellMover> ();
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "T1Shell") 
		{
			//hitAngle = Vector3.Angle (transform.position, T1Shell.transform.position);
			//lineOfSightArmor = Armor_Value / (1 - Mathf.Cos(hitAngle));

			//if (T1penetrationScript.Penetration >= lineOfSightArmor) {
			//	T2moblityScript.health -= 25;
			//	Destroy (other.gameObject);
			//	Debug.Log ("Penetration on Rear Turret!", this.gameObject);
			//} 
			//else if (T1penetrationScript.Penetration <= lineOfSightArmor) {
			//	Destroy (other.gameObject);
			//	Debug.Log ("Shot Bounced on Rear Turret!", this.gameObject);
			//}
		}
	}
}
