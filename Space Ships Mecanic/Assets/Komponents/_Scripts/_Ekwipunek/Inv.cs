using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Inspirowane https://youtu.be/6NXnxTNIWkc
/// </summary>
public class Inv : MonoBehaviour {

    public int obiektWRence = 0;
    public GameObject wyrzucanie;
    public GameObject[] obiekty;
    public GameObject[] obiektyPrzyKamerze;
    Zlecenia zlecenie;

	void Start () {
		
	}
	
	void Update () {

        zlecenie = FindObjectOfType<Zlecenia>();

        for (int i = 0; i < obiektyPrzyKamerze.Length; i++)
        {
            if(obiektWRence == i)
                obiektyPrzyKamerze[i].active = true;
            else if (obiektWRence != i)
            {
                obiektyPrzyKamerze[i].active = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Strzal();
        }
        if (Input.GetKeyDown(KeyCode.G) && obiektWRence != 0)
        {
            GameObject obiekt = Instantiate(obiekty[obiektWRence], wyrzucanie.transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;
            obiektWRence = 0;
        }
	}

    void Strzal()
    {
        Ray promien = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        RaycastHit[] trafienia = Physics.RaycastAll(promien, 5f);

        foreach (RaycastHit hit in trafienia)
        {
            if (hit.transform.root != transform)
            {
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
