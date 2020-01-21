using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{
    public bool Warsztat = true;
    public int sceneNumber;

    private void OnMouseDown()
    {
        Zlecenia zl = FindObjectOfType<Zlecenia>();

        if (!Warsztat) {
            if (zl.przyjete)
                SceneManager.LoadScene(zl.zlecenia + 2);
            if (!zl.przyjete)
                SceneManager.LoadScene(2);
        }

        if (Warsztat)
            SceneManager.LoadScene(sceneNumber);
    }
}
