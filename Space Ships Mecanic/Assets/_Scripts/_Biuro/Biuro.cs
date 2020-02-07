using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biuro : MonoBehaviour
{
    public GameObject gracz;
    public GameObject[] Teksty;
    public GameObject KlientGO;
    public GameObject kamera;

    Zlecenia zlecenia;
    Powrotny pow;

    bool klient = false;
    public Klient kl;



    
    void Start()
    {
        //Wyszukiwanie obiektów
        zlecenia = FindObjectOfType<Zlecenia>();
        pow = FindObjectOfType<Powrotny>();
    }

    
    void Update()
    {
        //Aktywowanie/Deaktywowanie klienta
        if (zlecenia.zlecenia == 0 && klient == false)
        {
            KlientGO.active = false;
            klient = false;
        }
        else if (zlecenia.zlecenia > 0 && klient == true)
        {
            KlientGO.active = true;
            klient = true;
        }
    }

    /// <summary>
    /// Aktywowanie gracza
    /// </summary>
    public void GraczActive()
    {
        zlecenia.przyjete = true;
        for (int i = 0; i < Teksty.Length; i++)
        {
            Teksty[i].active = false;
        }
        kamera.active = false;
        gracz.active = true;
        pow.pauza = false;
    }

}
