using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rigButton : MonoBehaviour
{
    public GameObject statusbox;
    public GameObject textbox;

    public static int numRigs = 0;

    public static bool turnOff = false;


    public GameObject fakeButton;
    public GameObject fakeText;

    public GameObject rButton;
    public GameObject buttonText;


    public double currentMoney;

    public double currentGPU;

    public static double rigValue = 800;
    public static double rigMultiplier = 1;



    public GameObject itemTemplate;
    public GameObject content;
    public GameObject rigStats;

   
    //when the rig is bought instatiate prefab in content
    public void Button_Click()
    {

        if(currentMoney >= rigValue && currentGPU >= 4)
        {
            GlobalCurrency.moneyCount = GlobalCurrency.moneyCount - rigValue;
            RAM.ramCount = RAM.ramCount - 4;

            //doubles values of the cost
            rigValue *= rigMultiplier;


            /////////////////////////////////////////////
            var copy = Instantiate(itemTemplate);

            copy.transform.SetParent(content.transform, false);
            /////////////////////////////////////////////
           

            numRigs++;

        }

        if(currentMoney < rigValue || currentGPU < 4)
        {
            statusbox.GetComponent<Text>().text = "Inefficent Funds or GPU(s)";
            statusbox.GetComponent<Animation>().Play("status");
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        currentMoney = GlobalCurrency.moneyCount;
        currentGPU = RAM.ramCount;

        rigStats.GetComponent<Text>().text = "Rigs: " + numRigs + " at " + PASSIVE_MONEY.placeHolder + "/second ";

        if(currentMoney >= rigValue && currentGPU >= 4)
        {
            fakeButton.SetActive(false);
            rButton.SetActive(true);

        }

        if(turnOff == true)
        {
            rButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOff = false;


        }
    

    }


}
