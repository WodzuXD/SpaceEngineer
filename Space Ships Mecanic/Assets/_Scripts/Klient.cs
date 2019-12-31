using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Klient : MonoBehaviour
{
    Zlecenia zlecemia;
    Powrotny pow;

    public GameObject[] klienci;
    public RigidbodyFirstPersonController gracz;
    public GameObject kamera;
    public GameObject[] Teksty;


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
                break;
        }
    }

    public void Klient1()
    {
        gracz.enabled = false;
        //kamera.active = true;
        Teksty[1].active = true;
        pow.pauza = true;
    }

    public void Klient2()
    {
        gracz.enabled = false;
        //kamera.active = true;
        Teksty[2].active = true;
        pow.pauza = true;
    }



}
