using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T2RearArmorReader : MonoBehaviour {

    public GameObject T2RearArmor;
    public Text RearArmorText;

    private T2RearChassisArmor t2reararmorScript;

    // Use this for initialization
    void Start()
    {
        t2reararmorScript = T2RearArmor.GetComponent<T2RearChassisArmor>();
        RearArmorText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        RearArmorText.text = ("Rear Armor: " + t2reararmorScript.Armor_Value);
    }
}
