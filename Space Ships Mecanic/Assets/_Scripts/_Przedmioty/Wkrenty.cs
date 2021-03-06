﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wkrenty : MonoBehaviour {

    //Progress wykręcania śróby
    public float progress = 0f;
    public float endDrill = 1f;

    float last;



    public GameObject srobaGO;
    public PudeleczkoSkrzyneczka pS;

	void Start () {
		
	}
	
	void Update () {

        //Animacja śróby
        if (progress != last)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, gameObject.transform.position -= new Vector3(0.001f * progress, 0f, 0f), Time.deltaTime * 10f);
            last = progress;
        }

        //Przesyłanie usunięcia do skrzynki
        if (progress >= endDrill)
        {
            if (pS.sroby[0] == 0)
            {
                if (pS.sroby[1] == 0)
                {
                    if (pS.sroby[2] == 0)
                    {
                         pS.sroby[3] = 0;
                    }
                    else pS.sroby[2] = 0;
                }
                else pS.sroby[1] = 0;
            }
            else pS.sroby[0] = 0;
            
            //Dodawanie przedmiotu na scene zamiast śróby
            GameObject obiekt = Instantiate(srobaGO, gameObject.transform.position, gameObject.transform.rotation) as GameObject;

            //Usuwanie śróby
            Destroy(gameObject);
        }
	}
}
