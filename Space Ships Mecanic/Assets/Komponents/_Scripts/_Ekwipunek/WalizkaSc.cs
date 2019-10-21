using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalizkaSc : MonoBehaviour {

    public Inv inwentory;

    public int[] sloty;

    Collider col = null;

    public GameObject[] wyrzucanie;

	void Start () {
        
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q) && col.transform.root.tag == "Player")
        {
            for (int i = 0; i < sloty.Length; i++)
            {
                if(sloty[i] != 0)
                {
                    GameObject obiekt = Instantiate(inwentory.obiekty[sloty[i]], wyrzucanie[i].transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;
                    sloty[i] = 0;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.tag == "Player")
            col = other;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.transform.root.tag == "Player")
            col = null;
    }
}
