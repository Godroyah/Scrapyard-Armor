using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplodeBooster : MonoBehaviour {

    public Transform self;

	// Use this for initialization
	void Start () 
    {
        StartCoroutine("Kaboom");
	}
	
    IEnumerator Kaboom ()
    {
        self.position = new Vector3(self.position.x, self.position.y, self.position.z - 3);
        yield return new WaitForSeconds(0.25f);
        Destroy(gameObject);
    }


}
