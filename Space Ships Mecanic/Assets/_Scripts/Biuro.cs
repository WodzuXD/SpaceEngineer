using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biuro : MonoBehaviour
{
    public GameObject gracz;
    public GameObject[] Teksty;

    Zlecenia zlecenia;
    Powrotny pow;
    bool klient = false;
    public GameObject kamera;


    public GameObject KlientGO;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        zlecenia = FindObjectOfType<Zlecenia>();
        pow = FindObjectOfType<Powrotny>();

        if (zlecenia.zlecenia == 0 && klient == true)
        {
            KlientGO.active = false;
            klient = false;
        }
        else if (zlecenia.zlecenia > 0 && klient == false)
        {
            KlientGO.active = true;
            klient = true;
        }
    }

    public void GraczActive()
    {
        for (int i = 0; i < Teksty.Length; i++)
        {
            if (i == 0)
            {
                Teksty[i].active = true;
            }
            else if (i != 0)
            {
                Teksty[i].active = false;
            }
        }
        kamera.active = false;
        pow.pauza = false;
        gracz.active = true;
    }

}
