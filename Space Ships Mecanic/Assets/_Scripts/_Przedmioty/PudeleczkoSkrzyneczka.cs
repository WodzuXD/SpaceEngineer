using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PudeleczkoSkrzyneczka : MonoBehaviour {

    public int[] sroby;
    public GameObject drzwiczki;
    public GameObject drzwiczkiPrzedmiot;

    public bool zamkniete = true;

	void Start () {
		
	}

    void Update() {

        //Otwieranie skrzynki
        if (zamkniete)
        {
            if (sroby[0] == 0)
            {
               if (sroby[1] == 0)
                {
                    if (sroby[2] == 0)
                    {
                        if (sroby[3] == 0)
                        {
                           GameObject obiekt = Instantiate(drzwiczkiPrzedmiot, drzwiczki.transform.position, drzwiczki.transform.rotation) as GameObject;
                           Destroy(drzwiczki);
                            zamkniete = false;
                       }
                    }
                }
            }
        }
	}
}
