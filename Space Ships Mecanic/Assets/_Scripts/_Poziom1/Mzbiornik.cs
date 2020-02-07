using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Włączanie zbiornika na statku (pomaga podczas otwierania klapy dolnej)
/// </summary>
public class Mzbiornik : MonoBehaviour
{

    public GameObject zbiornik;

    public void Zbiornik()
    {
        zbiornik.active = true;
    }
}
