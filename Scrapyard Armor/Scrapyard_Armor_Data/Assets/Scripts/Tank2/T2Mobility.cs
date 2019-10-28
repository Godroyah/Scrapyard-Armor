using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Mobility : MonoBehaviour {

	public GameObject T2Chassis;
	public GameObject T2Turret;
	public GameObject shell;
	//public GameObject T1Tank;

	private AudioSource gunSource;

	public Transform T2shellSpawn;
	public int health;

	private Rigidbody2D rb2d;



	//private Rigidbody2D otherTank;

	public float chassSpin; //for rotation speed
	public float chassZoom; //for drive speed


	public float roF; //rate of fire
	public float nextShell;

	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		//otherTank = T1Tank.GetComponent<Rigidbody2D> ();
		gunSource = GetComponent<AudioSource>();

		Physics2D.IgnoreCollision (T2Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2Turret.GetComponent<Collider2D> (), GetComponent<Collider2D> ());

	}

	// Update is called once per frame
	void Update () 
	{
        if (health < 0)
        {
            health = health - health;
        }

		if (health < 0) 
		{
			rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
		}

		Physics2D.IgnoreCollision (T2Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T2Turret.GetComponent<Collider2D> (), GetComponent<Collider2D> ());

        if (health > 0)
        {
            var chassRot = Input.GetAxis("T2Horizontal") * Time.deltaTime * chassSpin; //float is for rotation speed;
            var chassMove = Input.GetAxis("T2Vertical") * Time.deltaTime * chassZoom; //float is for drive speed;

            transform.Rotate(0, 0, chassRot);
            transform.Translate(0, chassMove, 0);
        }
        //if ((T1Tank.transform.position - this.transform.position).sqrMagnitude<1*1)
        //{
        //	Vector2 direction = T1Tank.transform.position - transform.position;
        //	otherTank.AddForceAtPosition (direction.normalized, transform.position);
        //}

        if (health > 0)
        {
            if (Input.GetButton("Fire2") && Time.time > nextShell)
            {
                gunSource.Play();

                nextShell = Time.time + roF;
                Instantiate(shell, T2shellSpawn.position, T2shellSpawn.rotation);
                shell.transform.rotation = T2shellSpawn.transform.rotation;
                //audioSource.Play (); Shot firing sound
            }
        }
        if (health <= 0)
        {
            StartCoroutine("OnDeath");
        }
	}
    IEnumerator OnDeath ()
    {
        yield return new WaitForSeconds(1.0f);
        gameObject.transform.position =
                new Vector3(gameObject.transform.position.x,
                            gameObject.transform.position.y,
                            gameObject.transform.position.z + 3);
    }
}
