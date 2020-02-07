using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progresslevl1 : MonoBehaviour
{
    public Slider progress;

    void Update()
    {
        //Sprawdzanie czy gracz wykonał zalecenie
        if (progress.value == 1f)
        {
            FindObjectOfType<Zlecenia>().wykonanie = true;
        }
    }

    /// <summary>
    /// Dodawanie punktów do progressu
    /// </summary>
    /// <param punkty="i"></param>
    public void PlusPrgs(float i)
    {
        progress.value += i;
    }
}
