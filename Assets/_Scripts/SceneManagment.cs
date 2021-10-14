using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneManagment : MonoBehaviour
{

    public GameObject sceneCanvas;

    public GameObject shopCanvas;

    public GameObject rigCanvas;

    public GameObject mainMenu;


    public static int isLoading = 0;

    public void getSHOP()
    {
        sceneCanvas.SetActive(false);

        shopCanvas.SetActive(true);


    }

    public void getMainScreen()
    {

        sceneCanvas.SetActive(true);

        shopCanvas.SetActive(false);

    }

    public void getRigScreen()
    {
        sceneCanvas.SetActive(false);

        rigCanvas.SetActive(true);

    }

    
    public void LoadGame()
    {

        

        sceneCanvas.SetActive(true);

        mainMenu.SetActive(false);

        isLoading = 1;



    }

    public void NewGame()
    {
        isLoading = 0;

        sceneCanvas.SetActive(true);

        mainMenu.SetActive(false);

    }

}



