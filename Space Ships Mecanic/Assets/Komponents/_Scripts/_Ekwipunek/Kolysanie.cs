using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolysanie : MonoBehaviour {

    public float szybkosc = 10f;
    public float mnoznik = 0.0015f;

	void Update () {
        Vector3 kolysanie = new Vector3(transform.localPosition.x - Input.GetAxis("Mouse X") * mnoznik, transform.localPosition.y - Input.GetAxis("Mouse Y") * mnoznik, 0f);
        transform.localPosition = Vector3.Lerp(kolysanie, Vector3.zero, Time.deltaTime * szybkosc);
    }
}
