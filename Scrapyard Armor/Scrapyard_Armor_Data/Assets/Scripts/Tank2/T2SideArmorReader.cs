using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T2SideArmorReader : MonoBehaviour {

    public GameObject T2SideArmor;
    public Text SideArmorText;

    private T2SideChassisArmor t2sidearmorScript;

    // Use this for initialization
    void Start()
    {
        t2sidearmorScript = T2SideArmor.GetComponent<T2SideChassisArmor>();
        SideArmorText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        SideArmorText.text = ("Flank Armor: " + t2sidearmorScript.Armor_Value);
    }
}
