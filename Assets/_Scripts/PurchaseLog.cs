using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{

    public GameObject AutoCookie;

    public void StartAutoCookie()
    {
        AutoCookie.SetActive(true);

        GlobalCurrency.moneyCount -= rigButton.rigValue;
        //doubles the value of a rig by 2 each time
        rigButton.rigValue *= 2;


    }
}
