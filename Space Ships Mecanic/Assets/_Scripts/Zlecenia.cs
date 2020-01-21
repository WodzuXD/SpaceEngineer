using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zlecenia : MonoBehaviour
{

    public int zlecenia;
    public bool przyjete = false;

    public GameObject canvas;


    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(canvas);
    }

    private void Update()
    {
        if (przyjete && zlecenia != 0)
        {
            canvas.active = false;
        }

        if (!przyjete && zlecenia != 0)
        {
            canvas.active = true;
        }
    }

}
