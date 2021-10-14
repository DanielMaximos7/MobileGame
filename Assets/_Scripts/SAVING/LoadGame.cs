using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LoadGame : MonoBehaviour
{
    public double saveGameCash;

    //buyram and RAM
    public int saveRamCount;
    public double saveRamCost;
    public double saveRamMultiplier;

    //rigbutton...
    public int saveNumRigs;
    public double saveRigValue;
    public double saveRigMultiplier;


    // Start is called before the first frame update
    public void Start()
    {

      


            string tempCash = PlayerPrefs.GetString("SavedMoney");
            saveGameCash = double.Parse(tempCash, System.Globalization.CultureInfo.InvariantCulture);
            GlobalCurrency.moneyCount = saveGameCash;

            Console.WriteLine(saveGameCash);

            string tempRamCost = PlayerPrefs.GetString("RamCost");
            buyRAM.ramCost = double.Parse(tempRamCost, System.Globalization.CultureInfo.InvariantCulture);
            

            RAM.ramCount = PlayerPrefs.GetInt("RamCount");
             


            string tempRamMulti = PlayerPrefs.GetString("RamMultiplayer");
            buyRAM.ramMultiplier = double.Parse(tempRamMulti, System.Globalization.CultureInfo.InvariantCulture);
             


            rigButton.numRigs = PlayerPrefs.GetInt("numRigs");


            string tempRigValue = PlayerPrefs.GetString("rigValue");
            rigButton.rigValue = double.Parse(tempRigValue, System.Globalization.CultureInfo.InvariantCulture);
          

            string tempRigMulti = PlayerPrefs.GetString("rigMultiplier");
            rigButton.rigMultiplier = double.Parse(tempRigMulti, System.Globalization.CultureInfo.InvariantCulture);
             
        




    }

   
}
