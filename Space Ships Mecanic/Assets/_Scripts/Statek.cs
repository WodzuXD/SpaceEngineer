using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statek : MonoBehaviour
{

    public int zbiornik = 0;
    public int szyba = 0;
    public int dziury = 3;

    public bool zb = false;
    public bool sz = false;
    public bool dz = false;
    public bool dz1 = false;
    public bool dz2 = false;

    public progresslevl1 pl1;

    void Start()
    {
        
    }

    void Update()
    {
        if (zbiornik == 1 && !zb)
        {
            pl1.PlusPrgs(0.2f);
            zb = true;
        }
        if (szyba == 1 && !sz)
        {
            pl1.PlusPrgs(0.2f);
            sz = true;
        }
        if (dziury == 2 && !dz)
        {
            pl1.PlusPrgs(0.2f);
            dz = true;
        }
        if (dziury == 1 && !dz1)
        {
            pl1.PlusPrgs(0.2f);
            dz1 = true;
        }
        if (dziury == 0 && !dz2)
        {
            pl1.PlusPrgs(0.2f);
            dz2 = true;
        }
    }
}
