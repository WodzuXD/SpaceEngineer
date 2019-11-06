using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zlecenia : MonoBehaviour
{

    public int zlecenia;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
