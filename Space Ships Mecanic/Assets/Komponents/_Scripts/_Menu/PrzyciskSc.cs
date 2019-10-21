using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrzyciskSc : MonoBehaviour {

    public enum enumPrzycisk { Graj, Opcje, Wyjscie};

    public enumPrzycisk przyciskiID;

    public MenuSc menuScript;

    private void OnMouseDown()
    {
        switch (przyciskiID)
        {
            case enumPrzycisk.Graj:
                menuScript.graBool = !menuScript.graBool;
                menuScript.opcjeBool = false;
                menuScript.wyjscieBool = false;
                break;
            case enumPrzycisk.Opcje:
                menuScript.opcjeBool = !menuScript.opcjeBool;
                menuScript.graBool = false;
                menuScript.wyjscieBool = false;
                break;
            case enumPrzycisk.Wyjscie:
                menuScript.wyjscieBool = !menuScript.wyjscieBool;
                menuScript.opcjeBool = false;
                menuScript.graBool = false;
                break;
        }
    }
}
