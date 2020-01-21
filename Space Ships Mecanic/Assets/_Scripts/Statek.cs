using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statek : MonoBehaviour
{

    public int zbiornik = 0;
    public int szyba = 0;
    public int dziury = 3;

    public Text t1;
    public Text t2;
    public Text t3;


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
            t1.text = "-Wymień Zbiorniik 1/1";
            pl1.PlusPrgs(0.2f);
            zb = true;
        }
        if (szyba == 1 && !sz)
        {
            t2.text = "-Wymień Szybę 1/1";
            pl1.PlusPrgs(0.2f);
            sz = true;
        }
        if (dziury == 2 && !dz)
        {
            t3.text = "-Zaspawaj dziury 1/3";
            pl1.PlusPrgs(0.2f);
            dz = true;
        }
        if (dziury == 1 && !dz1)
        {
            t3.text = "-Zaspawaj dziury 2/3";
            pl1.PlusPrgs(0.2f);
            dz1 = true;
        }
        if (dziury == 0 && !dz2)
        {
            t3.text = "-Zaspawaj dziury 3/3";
            pl1.PlusPrgs(0.2f);
            dz2 = true;
        }
    }
}
