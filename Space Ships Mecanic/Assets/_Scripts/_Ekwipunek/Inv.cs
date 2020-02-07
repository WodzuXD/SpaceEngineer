using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pomoc przy pisaniu tego skryptu https://youtu.be/6NXnxTNIWkc
/// </summary>
public class Inv : MonoBehaviour {

    public int obiektWRence = 0;
    public GameObject wyrzucanie;
    public GameObject[] obiekty;
    public GameObject[] obiektyPrzyKamerze;

    Zlecenia zlecenie;

	void Start () {
        //Wyszukiwanie obiektów
        zlecenie = FindObjectOfType<Zlecenia>();
    }

    void Update () {

        //Aktywowanie/Deaktywowanie obiektów w ręce
        for (int i = 0; i < obiektyPrzyKamerze.Length; i++)
        {
            if(obiektWRence == i)
                obiektyPrzyKamerze[i].active = true;
            else if (obiektWRence != i)
            {
                obiektyPrzyKamerze[i].active = false;
            }
        }

        //Przycik do "Strzału"
        if (Input.GetKeyDown(KeyCode.E))
        {
            Strzal();
        }

        //Wyrzucanie przedmiotu w ręce
        if (Input.GetKeyDown(KeyCode.G) && obiektWRence != 0)
        {
            GameObject obiekt = Instantiate(obiekty[obiektWRence], wyrzucanie.transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;
            obiektWRence = 0;
        }
	}

    /// <summary>
    /// -Wystrzeliwuje Ray z kamery gracza i wypisuje wszystkie natrafione przedmioty w zasięgu 5f
    /// </summary>
    void Strzal()
    {
        Ray promien = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        RaycastHit[] trafienia = Physics.RaycastAll(promien, 5f);

        foreach (RaycastHit hit in trafienia)
        {
            if (hit.transform.root != transform)
            {
                //Dodaje przedmiot do ręki
                if (hit.transform.root.tag == "Przedmiot")
                {
                    if (obiektWRence == 0)
                    {
                        obiektWRence = hit.transform.gameObject.GetComponent<Przedmiot>().przedmiotId;
                        Destroy(hit.transform.gameObject);
                    }
                    else if (obiektWRence != 0)
                    {
                        GameObject obiekt = Instantiate(obiekty[obiektWRence], wyrzucanie.transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;
                        obiektWRence = hit.transform.gameObject.GetComponent<Przedmiot>().przedmiotId;
                        Destroy(hit.transform.gameObject);
                    }
                }
                //Aktywuje klienta
                else if (hit.transform.root.tag == "klient")
                {
                    if(zlecenie.zlecenia == 1)
                    {
                        hit.transform.gameObject.transform.GetComponent<Klient>().klient = true;
                    }
                    if (zlecenie.zlecenia == 2)
                    {
                        hit.transform.gameObject.transform.GetComponent<Klient>().klient = true;
                    }
                }
            }
        }
    }
}
