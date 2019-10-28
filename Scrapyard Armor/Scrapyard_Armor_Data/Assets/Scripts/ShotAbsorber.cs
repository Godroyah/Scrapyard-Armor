using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAbsorber : MonoBehaviour {

    public GameObject shellExplode;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "T1Shell") 
		{
            Instantiate(shellExplode, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
		}
		else if (other.tag == "T2Shell") 
		{
            Instantiate(shellExplode, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
		}
	}
	//void OnCollisionEnter (Collision c)
	//{
		//float force = 3;

		//if (c.gameObject.tag == "T1Tank") 
		//{
			//Vector2 dir = c.contacts [0].point - transform.position;
			//dir = -dir.normalized;
			//GetComponent<Rigidbody2D> ().AddForce (dir * force);
		//}
		//if (c.gameObject.tag == "T2Tank") 
		//{
			//Vector2 dir = c.contacts [0].point - transform.position;
			//dir = -dir.normalized;
			//GetComponent<Rigidbody2D> ().AddForce (dir * force);
		//}
	//}
}
