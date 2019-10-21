using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZakonczeniePoziomu : MonoBehaviour {

    public SterowanieKokpitem sK;

     void OnMouseDown()
    {
        if (sK.zniszczenieStatku == false)
        {
            SceneManager.LoadScene(0);
        }
    }
}
