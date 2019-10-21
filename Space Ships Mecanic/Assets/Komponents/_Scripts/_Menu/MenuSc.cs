using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSc : MonoBehaviour {

    public Animator anim;

    public GameObject graObjGUI;
    public GameObject opcjeObjGUI;
    public GameObject wyjscieObjGUI;


    public bool graBool = false;
    public bool opcjeBool = false;
    public bool wyjscieBool = false;

	void Start () {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
	}
	
	void Update () {
        graObjGUI.active = graBool;
        opcjeObjGUI.active = opcjeBool;
        wyjscieObjGUI.active = wyjscieBool;

        if (graBool || opcjeBool || wyjscieBool)
        {
            anim.SetBool("zoom", true);
        }
        else
        {
            anim.SetBool("zoom", false);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            graBool = false;
            opcjeBool = false;
            wyjscieBool = false;
            anim.SetBool("zoom", false);
        }
    }
}
