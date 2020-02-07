using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolysanie : MonoBehaviour {
    
    //Czas zmiany pozycji obiektu w ręce
    public float szybkosc = 10f;

    //Mnożnik   
    //Użyty - ruch myszki * mnożnik
    public float mnoznik = 0.0015f;

	void Update () {
        //Zmiana pozycji obiektu wręce
        Vector3 kolysanie = new Vector3(transform.localPosition.x - Input.GetAxis("Mouse X") * mnoznik, transform.localPosition.y - Input.GetAxis("Mouse Y") * mnoznik, 0f);
        transform.localPosition = Vector3.Lerp(kolysanie, Vector3.zero, Time.deltaTime * szybkosc);
    }
}
