using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipElevator : MonoBehaviour
{

    public GameObject[] ship;
    public ShipElevator se;
    public ShipElevator se1;
    public float up;
    public bool movee;
    public bool buttonPouse;

    private void Update()
    {
       /* if (ship[0].transform.position.y < 1.5)
            ship[0].transform.position = new Vector3(0f, 1.5f, 0f);
        if (ship[0].transform.position.y > 5.5)
            ship[0].transform.position = new Vector3(0f, 5.5f, 0f);
        */

        for (int i = 0; i < ship.Length; i++)
        {
            if (movee)
            {
                ship[i].transform.position += new Vector3(0f, up, 0f) * Time.deltaTime;
            }
        }
        
    }

    private void OnMouseDown()
    {
        if (!buttonPouse)
        {
            if (se.movee)
                se.movee = false;
            movee = true;
        }
        else {
            se.movee = false;
            se1.movee = false;
        }
    }


}
