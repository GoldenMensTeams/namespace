using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Menu : MonoBehaviour {

    GameObject menuOnGame;
    GameObject playerGui;

    // Use this for initialization
    void Start () {
       playerGui = GameObject.FindGameObjectWithTag("PlayerGui");
       menuOnGame = GameObject.FindGameObjectWithTag("MenuOnGame");
    }
	void OpenMenu()
    {
        playerGui.SetActive(true);
        menuOnGame.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
        
       if (CnInputManager.GetButtonUp("OpenMenu"))
       {
           OpenMenu();
       }
        if (CnInputManager.GetButtonUp("Exit"))
        {
            Application.Quit();
            Debug.Log("quit");
        }
        if (CnInputManager.GetButtonUp("NewGame"))
        { 
            Debug.Log("New game");
        }
    }
}
