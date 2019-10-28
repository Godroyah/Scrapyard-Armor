using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1RearChassisArmor : MonoBehaviour {

    public GameObject shellExplode;

	public GameObject T1Tank;
	public GameObject T2Shell;
	//public GameObject T1Gun;
	//public GameObject T1GunTracker;

	private T1Mobility T1moblityScript;
	private T2ShellMover T2penetrationScript;
	//private T1GunTracker T1gunTrackerScript;

	public float Armor_Value = 60;
    public float leftOverDamage;

	public int ArmorRechargeRate;
	public float ArmorRechargeStart;
	public float TimetoArmorRecharge;

	private float nextArmorAdd = 0.0f;
	private float ArmorAdd = 1.0f;



	//public float hitAngle;
	//public float lineOfSightArmor;

	// Use this for initialization
	void Start () 
	{
		//T1gunTrackerScript = T1GunTracker.GetComponent<T1GunTracker> ();
		T1moblityScript = T1Tank.GetComponent<T1Mobility> ();
		T2penetrationScript = T2Shell.GetComponent<T2ShellMover> ();

	}

	// Update is called once per frame
	void Update ()
	{
        if (Armor_Value < 0)
        {
            Armor_Value = Armor_Value - Armor_Value;
        }
		if (Armor_Value < 60) {
			if (ArmorRechargeStart > TimetoArmorRecharge) {
				TimetoArmorRecharge += 0.1f;
                nextArmorAdd = Time.time;
			} 
            if (ArmorRechargeStart < TimetoArmorRecharge && Time.time > nextArmorAdd) 
            {	
					nextArmorAdd += ArmorAdd;
					Armor_Value += ArmorRechargeRate;	
			}
		} 
		else if (Armor_Value == 60) 
		{
			TimetoArmorRecharge = 0;
		} 
		//RaycastHit2D hit = Physics2D.Linecast (T1Gun.transform.position, transform.position);
		//Vector3 normalVector = hit.normal;
		//Vector3 impactVector = Vector3.Normalize (transform.position - T1Gun.transform.position);
		//hitAngle = Mathf.RoundToInt((Vector2.Angle (normalVector, impactVector)-180));
		//hitAngle = Mathf.Abs(hitAngle * Mathf.Rad2Deg);
		//hitAngle = hitAngle * Mathf.Rad2Deg;

		//Debug.Log("GameObject: " + hit.transform.name);
		//Debug.Log ("Normal Vector: " + normalVector);
		//Debug.Log ("Impact Vector: " + normalVector);
		//Debug.Log ("Calculated Angle: " + hitAngle);
		//Debug.DrawLine (T1Gun.transform.position, transform.position, Color.red);


		//lineOfSightArmor = (Armor_Value / (Mathf.Cos (hitAngle)));
	}

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.tag == "T2Shell") 
		{
			if (Armor_Value > 0) 
			{
                if (Armor_Value < T2penetrationScript.T2shellDamage)
                {
                    T1moblityScript.health = T1moblityScript.health - (T2penetrationScript.T2shellDamage - (int)Armor_Value);
                }
                Armor_Value = Armor_Value - T2penetrationScript.T2shellDamage;
				TimetoArmorRecharge = 0;
                Instantiate(shellExplode, other.transform.position, other.transform.rotation);
				Destroy (other.gameObject);
			} 
			else if (Armor_Value <= 0) 
			{
                Armor_Value += -Armor_Value;
				T1moblityScript.health = T1moblityScript.health - T2penetrationScript.T2shellDamage;
				TimetoArmorRecharge = 0;
                Instantiate(shellExplode, other.transform.position, other.transform.rotation);
				Destroy (other.gameObject);
			}
			//if (T1penetrationScript.Penetration >= lineOfSightArmor) 
			//{
			//T2moblityScript.health -= 25;
			//Destroy (other.gameObject);
			//Debug.Log ("Penetration on Front Chassis!", this.gameObject);
			//}
			//else if (T1penetrationScript.Penetration <= lineOfSightArmor) 
			//{
			//	Destroy (other.gameObject);
			//	Debug.Log ("Shot Bounced on Front Chassis!", this.gameObject);
			//}
		} 

	}
}
