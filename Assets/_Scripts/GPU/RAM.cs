using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RAM : MonoBehaviour
{

    public static int ramCount;
    public GameObject ramDisplay;
    public double internalRAM;



    // Update is called once per frame
    void Update()
    {
        internalRAM = ramCount;
        ramDisplay.GetComponent<Text>().text = "GPU: " + internalRAM;

    }
}
