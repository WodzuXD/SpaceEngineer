using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tworzenie : MonoBehaviour {

    public int wRence = 0;

    public GameObject[] obiekty;

	void Start () {
		
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(1))
            Strzal();
	}

    void Strzal()
    {
        Ray promien = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        RaycastHit[] trafienia = Physics.RaycastAll(promien, 2f);

        foreach (RaycastHit hit in trafienia)
        {
            if (hit.transform.root != transform)
            {
                GameObject obiekt = Instantiate(obiekty[wRence], hit.transform.position - new Vector3(0f,-1f,0f), new Quaternion(90f, 0, 90f, 0)) as GameObject;
            }
        }
    }
}
