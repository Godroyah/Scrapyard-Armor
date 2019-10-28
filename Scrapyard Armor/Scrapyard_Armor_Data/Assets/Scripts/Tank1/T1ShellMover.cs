using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1ShellMover : MonoBehaviour {

    public Transform self;

    private Rigidbody2D rb;
	public float speed;
	public int Penetration;
	public Vector2 shellStartPosition;
	public int T1shellDamage = 30;

   // public Collider2D OakTree;
    //public Collider2D TreeCluster;
   // public Collider2D TreeLine;

   // public GameObject shellExplode;

	//public float hitAngle;

	//public GameObject FCArmor;

	// Use this for initialization
	void Start () 
	{

		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = transform.up * speed;
		shellStartPosition = rb.position;

        //OakTree = GetComponent<Collider2D>();
        //TreeCluster = GetComponent<Collider2D>();
       // TreeLine = GetComponent<Collider2D>();

		//Physics2D.IgnoreCollision (T2Tank.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T2Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		//Physics2D.IgnoreCollision (T2Turret.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}

	//private void OnCollisionEnter2D(Collision2D collision)
	//{
    //    Instantiate(shellExplode, self.position, self.rotation);
	//}

	void Update ()
	{

        //RaycastHit2D hit = Physics2D.Linecast (transform.position, FCArmor.transform.position);
        //Vector3 normalVector = hit.normal;
        //Vector3 impactVector = Vector3.Normalize (transform.position - FCArmor.transform.position);
        //hitAngle = Mathf.Abs(Mathf.RoundToInt((Vector2.Angle (normalVector, impactVector)-180)));
        //hitAngle = hitAngle * Mathf.Rad2Deg;
        //hitAngle = hitAngle * Mathf.Rad2Deg;

        //Debug.Log("GameObject: " + hit.transform.name);
        //Debug.Log ("Normal Vector: " + normalVector);
        //Debug.Log ("Impact Vector: " + normalVector);
        //Debug.Log ("Calculated Angle: " + hitAngle);

        //Physics2D.IgnoreCollision(OakTree, GetComponent<Collider2D>());
        //Physics2D.IgnoreCollision(TreeCluster, GetComponent<Collider2D>());
        //Physics2D.IgnoreCollision(TreeLine, GetComponent<Collider2D>());
    }
}
