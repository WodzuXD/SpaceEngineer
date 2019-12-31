using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progresslevl1 : MonoBehaviour
{

    public Slider progress;

    void Update()
    {
        
    }

    public void PlusPrgs(float i)
    {
        progress.value += i;
    }
}
