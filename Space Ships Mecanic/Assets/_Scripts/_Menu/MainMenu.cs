using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Włącza grę
    /// </summary>
    public void PlayDemo()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Wychodzi z gry
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
