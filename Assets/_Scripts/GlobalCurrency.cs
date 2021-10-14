using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCurrency : MonoBehaviour
{

    public static double moneyCount;
    public GameObject moneyDisplay;
    public double internalMoney;



    // Update is called once per frame
    void Update()
    {
        internalMoney = moneyCount;
        moneyDisplay.GetComponent<Text>().text = "Money: " + internalMoney;

    }
}
