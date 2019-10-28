using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T2HealthText : MonoBehaviour {

    public GameObject T2Tank;
    public Text healthRecordText;

    private T2Mobility t2healthScript;

    // Use this for initialization
    void Start()
    {
        t2healthScript = T2Tank.GetComponent<T2Mobility>();
        healthRecordText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthRecordText.text = ("Health: " + t2healthScript.health);
    }
}
