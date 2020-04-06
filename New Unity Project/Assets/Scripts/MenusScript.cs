using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenusScript : MonoBehaviour
{
    
    public void PVE()
    {
        SceneManager.LoadScene("PlayerVsIA");
    }
    public void PVP()
    {
        SceneManager.LoadScene("PlayerVsPlayer");
    }
    /*
    public void Act3()
    {
        SceneManager.LoadScene("Act_3");
    }
    */

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}