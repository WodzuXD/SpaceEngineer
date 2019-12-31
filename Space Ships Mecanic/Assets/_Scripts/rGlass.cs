using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rGlass : MonoBehaviour
{

    public ShipPod sp;
    public int hp = 100;

    void Start()
    {
        
    }

    void Update()
    {
        if (hp <= 0)
        {
            sp.rSzyba = false;
            Destroy(gameObject);
        }
    }
}
