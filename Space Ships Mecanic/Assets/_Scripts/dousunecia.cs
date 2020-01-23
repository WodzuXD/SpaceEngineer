using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class dousunecia : MonoBehaviour
{

    public bool scena = false;
    Zlecenia zla;

    private void Update()
    {
        zla = FindObjectOfType<Zlecenia>();
        if (SceneManager.sceneCount != 1)
        {
            scena = true;
        }
        if (SceneManager.sceneCount == 1 && !scena)
            if (zla.scena)
                zla.pod.Add(gameObject.GetComponent<dousunecia>());
    }
}
