﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wkrenty : MonoBehaviour {

    public float progress = 0f;

    public float endDrill = 1f;

    public GameObject srobaGO;
    public PudeleczkoSkrzyneczka pS;

	void Start () {
		
	}
	
	void Update () {
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

            GameObject obiekt = Instantiate(srobaGO, gameObject.transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;

            Destroy(gameObject);
        }
	}
}
