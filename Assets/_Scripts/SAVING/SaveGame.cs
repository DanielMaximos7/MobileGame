using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveGame : MonoBehaviour
{

   


    public GameObject saveButton;    

    public void SaveTheGame()
    {


        string gameCash = (GlobalCurrency.moneyCount).ToString();
        string ramCost = (buyRAM.ramCost).ToString();
        string ramMultiplier = (buyRAM.ramMultiplier).ToString();
        string rigValue = (rigButton.rigValue).ToString();
        string rigMultiplier = (rigButton.rigMultiplier).ToString();



        PlayerPrefs.SetString("SavedMoney", gameCash);

        
        PlayerPrefs.SetString("RamCost", ramCost);

        
        PlayerPrefs.SetInt("RamCount", RAM.ramCount);


        PlayerPrefs.SetString("RamMultiplayer", ramMultiplier);

        PlayerPrefs.SetInt("numRigs", rigButton.numRigs);

        PlayerPrefs.SetString("rigValue", rigValue);

        PlayerPrefs.SetString("rigMultiplier", rigMultiplier);

        PlayerPrefs.Save();

        Debug.Log(PlayerPrefs.GetInt("RamCount"));

    }
}
