using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject T1Tank;
	public GameObject T2Tank;
	public GameObject ScoringObject;

	private AudioSource battleMusic;

    public GameObject P1Round1;
    public GameObject P1Round2;
    public GameObject P1Round3;
    public GameObject P1Round4;
    public GameObject P1Round5;
    public GameObject P1Victory;
    public GameObject P1Defeat;

    public GameObject P2Round1;
    public GameObject P2Round2;
    public GameObject P2Round3;
    public GameObject P2Round4;
    public GameObject P2Round5;
    public GameObject P2Victory;
    public GameObject P2Defeat;

    public GameObject T1TankExplosion1;
    public GameObject T1TankExplosion2;
    public GameObject T1TankExplosion3;
    public GameObject T1TankExplosion4;
    public GameObject T1TankExplosion5;

    public GameObject T2TankExplosion1;
    public GameObject T2TankExplosion2;
    public GameObject T2TankExplosion3;
    public GameObject T2TankExplosion4;
    public GameObject T2TankExplosion5;

	private T1Mobility t1MobilityScript;
	private T2Mobility t2MobilityScript;
	private Scoring scoringScript;

	public int maxScoreT1;
	public int maxScoreT2;

	// Use this for initialization


	void Start () 
	{
		battleMusic = GetComponent<AudioSource>();

		battleMusic.Play ();

		ScoringObject = GameObject.Find ("ScoreObject");
		scoringScript = ScoringObject.GetComponent<Scoring> ();
		t1MobilityScript = T1Tank.GetComponent<T1Mobility> ();
		t2MobilityScript = T2Tank.GetComponent<T2Mobility> ();

        if (scoringScript.T1Wins + scoringScript.T2Wins == 0)
        {
            StartCoroutine("Round1Display");
        }
        if (scoringScript.T1Wins + scoringScript.T2Wins == 1)
        {
            StartCoroutine("Round2Display");
        }
        if (scoringScript.T1Wins + scoringScript.T2Wins == 2)
        {
            StartCoroutine("Round3Display");
        }
        if (scoringScript.T1Wins + scoringScript.T2Wins == 3)
        {
            StartCoroutine("Round4Display");
        }
        if (scoringScript.T1Wins + scoringScript.T2Wins == 4)
        {
            StartCoroutine("Round5Display");
        }


		maxScoreT1 = scoringScript.T1Wins + 1;
        maxScoreT2 = scoringScript.T2Wins + 1;
	}

	void Update ()
	{
		
        //quit
		if (Input.GetButton ("Quit"))
			{
			StartCoroutine ("Quit");
			}

        //scoring

		if (t1MobilityScript.health <= 0 && maxScoreT2 == 1) 
		{
			StartCoroutine ("NextRound");
			if (scoringScript.T2Wins < maxScoreT2)
			{
				scoringScript.T2Wins += 1;
			}
		}
		else if (t1MobilityScript.health <= 0 && maxScoreT2 == 2) 
		{
			StartCoroutine ("NextRound");
			if (scoringScript.T2Wins < maxScoreT2)
			{
				scoringScript.T2Wins += 1;
			}
		}
		else if (t1MobilityScript.health <= 0 && maxScoreT2 == 3) 
		{
			StartCoroutine ("NextRound");
			if (scoringScript.T2Wins < maxScoreT2)
			{
                //scoringScript.T2Wins += 1;
                P2Victory.SetActive(true);
                P1Defeat.SetActive(true);
				StartCoroutine ("StartScreen");
			}
		}
		if (t2MobilityScript.health <= 0 && maxScoreT1 == 1) 
		{
			StartCoroutine ("NextRound");
			if (scoringScript.T1Wins < maxScoreT1)
			{
				scoringScript.T1Wins += 1;
			}
		}
		else if (t2MobilityScript.health <= 0 && maxScoreT1 == 2) 
		{
			StartCoroutine ("NextRound");
			if (scoringScript.T1Wins < maxScoreT1)
			{
				scoringScript.T1Wins += 1;
			}
		}
		else if (t2MobilityScript.health <= 0 && maxScoreT1 == 3) 
		{
			StartCoroutine ("NextRound");
			if (scoringScript.T1Wins < maxScoreT1)
			{
				//scoringScript.T1Wins += 1;
                P1Victory.SetActive(true);
                P2Defeat.SetActive(true);
				StartCoroutine ("StartScreen");
			}
		}

        //death explosions

        if (t1MobilityScript.health <= 0)
        {
            StartCoroutine("Tank1Death");
        }
        else if (t2MobilityScript.health <= 0)
        {
            StartCoroutine("Tank2Death");
        }

	}

    //round restart/game end
	
	IEnumerator NextRound () 
	{
		Debug.Log ("Level is Restarting");
		yield return new WaitForSeconds (5.0f);
		SceneManager.LoadScene ("ScrapyardArmor");
	}
	IEnumerator StartScreen ()
	{
		Debug.Log ("Back to Start!");
		yield return new WaitForSeconds (5.0f);
		SceneManager.LoadScene ("StartMenu");
	}
	IEnumerator Quit ()
	{
		Debug.Log ("Back to Start!");
		yield return new WaitForSeconds (3.0f);
		SceneManager.LoadScene ("StartMenu");
	}

    //Co-routines for Round displays

    IEnumerator Round1Display ()
    {
        P1Round1.SetActive(true);
        P2Round1.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        P1Round1.SetActive(false);
        P2Round1.SetActive(false);
    }
    IEnumerator Round2Display()
    {
        P2Round2.SetActive(true);
        P1Round2.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        P1Round2.SetActive(false);
        P2Round2.SetActive(false);
    }
    IEnumerator Round3Display()
    {
        P1Round3.SetActive(true);
        P2Round3.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        P1Round3.SetActive(false);
        P2Round3.SetActive(false);
    }
    IEnumerator Round4Display()
    {
        P1Round4.SetActive(true);
        P2Round4.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        P1Round4.SetActive(false);
        P2Round4.SetActive(false);
    }
    IEnumerator Round5Display()
    {
        P1Round5.SetActive(true);
        P2Round5.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        P1Round5.SetActive(false);
        P2Round5.SetActive(false);
    }

    //deathsplosion routines
    IEnumerator Tank1Death ()
    {
        T1TankExplosion1.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T1TankExplosion1.SetActive(false);
        T1TankExplosion4.SetActive(true);
        T1TankExplosion3.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T1TankExplosion4.SetActive(false);
        T1TankExplosion3.SetActive(false);
        T1TankExplosion2.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T1TankExplosion2.SetActive(false);
        T1TankExplosion5.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T1TankExplosion5.SetActive(false);
    }
    IEnumerator Tank2Death ()
    {
        T2TankExplosion1.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T2TankExplosion1.SetActive(false);
        T2TankExplosion4.SetActive(true);
        T2TankExplosion3.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T2TankExplosion4.SetActive(false);
        T2TankExplosion3.SetActive(false);
        T2TankExplosion2.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T2TankExplosion2.SetActive(false);
        T2TankExplosion5.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        T2TankExplosion5.SetActive(false);
    }

}
