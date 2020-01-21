using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Klient : MonoBehaviour
{
    Zlecenia zlecemia;
    Powrotny pow;

    public Biuro biu;

    public GameObject[] klienci;
    public GameObject gracz;
    public GameObject kamera;
    public GameObject[] Teksty;
    public bool klient = false;

    void Start()
    {
        
    }

    void Update()
    {
        zlecemia = FindObjectOfType<Zlecenia>();
        pow = FindObjectOfType<Powrotny>();

        switch (zlecemia.zlecenia)
        {
            case 1:
                for (int i = 0; i < klienci.Length; i++)
                {
                    klienci[0].active = true;
                    if (i != 0)
                    {
                        klienci[i].active = false;
                    }
                }
                if (klient)
                {
                    Klient1();
                    klient = false;
                }
                break;
            case 2:
                for (int i = 0; i < klienci.Length; i++)
                {
                    klienci[1].active = true;
                    if (i != 1)
                    {
                        klienci[i].active = false;
                    }
                }
                if (klient)
                {
                    Klient2();
                    klient = false;
                }
                break;
        }
    }

    public void Klient1()
    {
        gracz.active = false;
        kamera.active = true;
        Teksty[1].active = true;
        pow.pauza = true;
    }

    public void Klient2()
    {
        gracz.active = false;
        kamera.active = true;
        Teksty[2].active = true;
        pow.pauza = true;
    }
}
