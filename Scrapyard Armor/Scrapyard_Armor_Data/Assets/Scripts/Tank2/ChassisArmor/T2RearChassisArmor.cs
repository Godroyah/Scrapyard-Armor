using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2RearChassisArmor : MonoBehaviour {

    public GameObject shellExplode;

	public GameObject T2Tank;
	public GameObject T1Shell;

	private T2Mobility T2moblityScript;
	private T1ShellMover T1penetrationScript;

	public float Armor_Value = 30;
	public int ArmorRechargeRate;
	public float ArmorRechargeStart;
	public float TimetoArmorRecharge;


	private float nextArmorAdd = 0.0f;
	private float ArmorAdd = 1.0f;

	//public float hitAngle;
	//public float lineOfSightArmor;

	// Use this for initialization
	void Start () {



		T2moblityScript = T2Tank.GetComponent<T2Mobility> ();
		T1penetrationScript = T1Shell.GetComponent<T1ShellMover> ();
		
	}

	void Update ()
	{
        if (Armor_Value < 0)
        {
            Armor_Value = Armor_Value - Armor_Value;
        }
		if (Armor_Value < 30) 
		{
			if (ArmorRechargeStart > TimetoArmorRecharge) 
			{
				TimetoArmorRecharge += 0.1f;
                nextArmorAdd = Time.time;
			} 
			else if (ArmorRechargeStart < TimetoArmorRecharge) 
			{
				if (Time.time > nextArmorAdd) {
					nextArmorAdd += ArmorAdd;
					Armor_Value += ArmorRechargeRate;
				} 
			}
		} 
		else if (Armor_Value == 30) 
		{
			TimetoArmorRecharge = 0;
		}
	}
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "T1Shell") 
		{
			if (Armor_Value > 0) 
			{
                if (Armor_Value < T1penetrationScript.T1shellDamage)
                {
                    T2moblityScript.health = T2moblityScript.health - (T1penetrationScript.T1shellDamage - (int)Armor_Value);
                }
				Armor_Value = Armor_Value - T1penetrationScript.T1shellDamage;
				TimetoArmorRecharge = 0;
                Instantiate(shellExplode, other.transform.position, other.transform.rotation);
				Destroy (other.gameObject);
			} 
			else if (Armor_Value <= 0) 
			{
				Armor_Value += -Armor_Value;
				T2moblityScript.health = T2moblityScript.health - T1penetrationScript.T1shellDamage;
				TimetoArmorRecharge = 0;
                Instantiate(shellExplode, other.transform.position, other.transform.rotation);
				Destroy (other.gameObject);
			}
			//hitAngle = Vector3.Angle (transform.position, T1Shell.transform.position);
			//lineOfSightArmor = Armor_Value / (1 - Mathf.Cos(hitAngle));

			//if (T1penetrationScript.Penetration >= lineOfSightArmor) {
			//	T2moblityScript.health -= 25;
			//	Destroy (other.gameObject);
			//	Debug.Log ("Penetration on Rear Chassis!", this.gameObject);
			//} 
		//else if (T1penetrationScript.Penetration <= lineOfSightArmor) {
			//	Destroy (other.gameObject);
			//	Debug.Log ("Shot Bounced on Rear Chassis!", this.gameObject);
			//}
			}
		}
	}

