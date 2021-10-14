using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyRAM : MonoBehaviour
{
    public GameObject textBox;
    public static double ramCost = 200;
    public static double ramMultiplier = 1.25;

    public GameObject statusbox;


    public void ClickTheButton()
    {

        if(GlobalCurrency.moneyCount < ramCost)
        {

            statusbox.GetComponent<Text>().text = "Inefficent Funds";
            statusbox.GetComponent<Animation>().Play("status");

            //change a text box to say inefficent currency

        }

        //purchasing RAM can make artifical economy
        else
        {

            GlobalCurrency.moneyCount -= ramCost;
            RAM.ramCount += 1;

            ramCost = ramCost * ramMultiplier;

            
        }

        

    }
}
