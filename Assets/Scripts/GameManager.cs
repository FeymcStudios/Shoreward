using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;

public class GameManager : MonoBehaviour
{

    #region Start&Quit
    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void RestartGameButton()
    {
        SceneManager.LoadScene(1);
    }
    #endregion

}