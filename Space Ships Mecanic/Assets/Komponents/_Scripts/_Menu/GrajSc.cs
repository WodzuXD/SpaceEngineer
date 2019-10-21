using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GrajSc : MonoBehaviour {
    public enum rodzaj { NowaGra,RodzajPoziomu,Wstecz,Wyjscie, Testowa,}
    public rodzaj rodzajNacisniety;
    public MenuSc menu;
    private void OnMouseDown()
    {
        switch (rodzajNacisniety)
        {
            case rodzaj.NowaGra:
                SceneManager.LoadScene(1);
                break;
            case rodzaj.Testowa:
                SceneManager.LoadScene(2);
                break;
            case rodzaj.RodzajPoziomu:

                break;
            case rodzaj.Wstecz:
                menu.graBool = false;
                menu.opcjeBool = false;
                menu.wyjscieBool = false;
                break;
            case rodzaj.Wyjscie:
                Application.Quit();
                break;
        }
    }
}
