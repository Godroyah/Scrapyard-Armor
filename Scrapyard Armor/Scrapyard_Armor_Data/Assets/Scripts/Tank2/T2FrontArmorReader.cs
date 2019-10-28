using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T2FrontArmorReader : MonoBehaviour {

    public GameObject T2FrontalArmor;
    public Text FrontArmorText;

    private T2FrontChassisArmor t2frontarmorScript;

    // Use this for initialization
    void Start()
    {
        t2frontarmorScript = T2FrontalArmor.GetComponent<T2FrontChassisArmor>();
        FrontArmorText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        FrontArmorText.text = ("Frontal Armor: " + t2frontarmorScript.Armor_Value);
    }
}
