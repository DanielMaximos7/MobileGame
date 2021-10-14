using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPUcost : MonoBehaviour
{

    public GameObject gpucost;


    // Update is called once per frame
    void Update()
    {
        gpucost.GetComponent<Text>().text = "$ " + buyRAM.ramCost;

    }
}
