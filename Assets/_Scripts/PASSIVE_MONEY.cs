using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PASSIVE_MONEY : MonoBehaviour
{


    public bool CreatingMoney = false;

    public static int MoneyIncrease = 1;
    public double InternalIncrease;

    public int x;

    public double percentCoefficient = 1;

    public static double placeHolder;

    



    // Update is called once per frame
    void Update()
    {

        x = rigButton.numRigs;

        InternalIncrease = x * percentCoefficient * MoneyIncrease;

        placeHolder = InternalIncrease;

        
        
        if(CreatingMoney == false)
        {
            CreatingMoney = true;
            StartCoroutine(CreateTheMoney());
        }
    }

    IEnumerator CreateTheMoney()
    {
        GlobalCurrency.moneyCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingMoney = false;

    }

    public void upgrade()
    {
        percentCoefficient = percentCoefficient * 1.15;

    }

}
