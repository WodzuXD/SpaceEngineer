using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Winda do warsztatu
/// </summary>
public class Elevator : MonoBehaviour
{
    public bool Warsztat = true;
    public int sceneNumber;

    private void OnMouseDown()
    {
        //Dodawnie obiektu
        Zlecenia zl = FindObjectOfType<Zlecenia>();

        //Sprawdzanie czy gracz ma aktualnie jakies zlecenia
        if (!Warsztat) {
            if (zl.przyjete)
                SceneManager.LoadScene(zl.zlecenia + 2);
            if (!zl.przyjete)
                SceneManager.LoadScene(2);
        }

        //Przenoszenie gracza na scene
        if (Warsztat)
            SceneManager.LoadScene(sceneNumber);
    }
}
