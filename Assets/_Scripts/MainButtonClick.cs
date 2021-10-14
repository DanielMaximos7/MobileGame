using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;
    public double x = 1;
    public double y = 100;


    public void ClickTheButton()
    {
        GlobalCurrency.moneyCount += x*y;

    }
}
