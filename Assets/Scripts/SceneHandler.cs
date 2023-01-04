using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    //loads game scene
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //loads main menu scene
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //exits editor gamemode or exits application
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
