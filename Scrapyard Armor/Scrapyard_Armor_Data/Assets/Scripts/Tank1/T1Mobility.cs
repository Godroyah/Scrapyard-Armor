using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1Mobility : MonoBehaviour {

	public GameObject T1Chassis;
	public GameObject T1Turret;
    public GameObject shell;

	//public AudioClip gunShotSound;

	private AudioSource gunSource;

    private Rigidbody2D rb2d;

    //public bool gunBlast;
	//public GameObject T2Tank;

	public Transform T1shellSpawn;
	public int health;

	//private Rigidbody2D otherTank;

	public float chassSpin; //for rotation speed
	public float chassZoom; //for drive speed


	public float roF; //rate of fire
	public float nextShell;

	// Use this for initialization
	void Start () 
	{
        rb2d = GetComponent<Rigidbody2D>();
        //otherTank = T2Tank.GetComponent<Rigidbody2D> ();
        //gunBlast = false;
		gunSource = GetComponent<AudioSource>();

		Physics2D.IgnoreCollision (T1Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1Turret.GetComponent<Collider2D> (), GetComponent<Collider2D> ());

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

		Physics2D.IgnoreCollision (T1Chassis.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (T1Turret.GetComponent<Collider2D> (), GetComponent<Collider2D> ());

        if (health > 0)
        {
            var chassRot = Input.GetAxis("T1Horizontal") * Time.deltaTime * chassSpin; //float is for rotation speed;
            var chassMove = Input.GetAxis("T1Vertical") * Time.deltaTime * chassZoom; //float is for drive speed;

            transform.Rotate(0, 0, chassRot);
            transform.Translate(0, chassMove, 0);
        }
        //if ((T2Tank.transform.position - this.transform.position).sqrMagnitude<1*1)
        //{
        //	Vector2 direction = T2Tank.transform.position - transform.position;
        //	otherTank.AddForceAtPosition (direction.normalized, transform.position);
        //}

        if (health > 0)
        {
            if (Input.GetButton("Fire1") && Time.time > nextShell)
            {
                // gunBlast = true;
                gunSource.Play();

                nextShell = Time.time + roF;
                Instantiate(shell, T1shellSpawn.position, T1shellSpawn.rotation);
                shell.transform.rotation = T1shellSpawn.transform.rotation;
                //audioSource.Play (); Shot firing sound
            }
        }
        if (health <= 0)
        {
            StartCoroutine("OnDeath");
        }
    }
    IEnumerator OnDeath()
    {
        yield return new WaitForSeconds(1.0f);
        gameObject.transform.position =
                new Vector3(gameObject.transform.position.x,
                            gameObject.transform.position.y,
                            gameObject.transform.position.z + 3);
    }   
	
}

