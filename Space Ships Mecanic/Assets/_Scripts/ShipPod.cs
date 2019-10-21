using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPod : MonoBehaviour
{
    public int[] srobypod;
    public GameObject drzwiczki;
    public GameObject drzwiczkiPrzedmiot;
    public GameObject zbiornik;

    public bool zamkniete = true;

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
                            GameObject obiekt = Instantiate(drzwiczkiPrzedmiot, drzwiczki.transform.position, new Quaternion(90f, 0, 90f, 0)) as GameObject;
                            drzwiczki.active = false;
                            zbiornik.active = true;
                            zamkniete = false;
                        }
                    }
                }
            }
        }
    }
}
