using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuCtrl : HaroMonobehavior
{
    public void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplayscene");
    }
}
