using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPod : MonoBehaviour
{
    public int[] srobypod;
    public GameObject drzwiczki;
    public GameObject drzwiczkiPrzedmiot;
    public GameObject zbiornik;
    public GameObject zbiornikPrzedmiot;

    public GameObject mSzyba;
    public GameObject rSzybaGo;
    public GameObject rSzybaPrzedmiot;
    public GameObject nSzyba;

    public bool rSzyba = true;
    public bool zamkniete = true;

    public Statek st;

    void Start()
    {

    }

    void Update()
    {
        if (zamkniete)
        {
            if (srobypod[0] == 0)
            {
                if (srobypod[1] == 0)
                {
                    if (srobypod[2] == 0)
                    {
                        if (srobypod[3] == 0)
                        {
                            GameObject drzwiczkiii = Instantiate(drzwiczkiPrzedmiot, drzwiczki.transform.position, drzwiczki.transform.rotation) as GameObject;
                            GameObject zbiornikkk = Instantiate(zbiornikPrzedmiot, zbiornik.transform.position, zbiornik.transform.rotation) as GameObject;
                            drzwiczki.active = false;
                            zamkniete = false;
                        }
                    }
                }
            }
        }

        if (!rSzyba)
        {
            rSzybaGo.active = false;
            mSzyba.active = true;
            GameObject rSzybaa = Instantiate(rSzybaPrzedmiot, rSzybaGo.transform.position, rSzybaGo.transform.rotation) as GameObject;
            rSzyba = true;
        }

        if (st.szyba == 1)
        {
            nSzyba.active = true;
        }
    }
}
