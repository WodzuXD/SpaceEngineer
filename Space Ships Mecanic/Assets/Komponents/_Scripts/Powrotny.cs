using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Powrotny : MonoBehaviour {

    public GameObject panel;
    bool pauza = false;
    public Image im;

    public RigidbodyFirstPersonController rfpc;

	void Start () {
		
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            pauza = !pauza;

        panel.active = pauza;
        rfpc.enabled = !pauza;
        im.enabled = !pauza;

        if (pauza)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (!pauza)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void Wroc()
    {
        pauza = false;
    }

    public void MenuWroc()
    {
        SceneManager.LoadScene(0);
    }

    private void OnGUI()
    {
        if (pauza)
        {
            if (GUI.Button(new Rect(Screen.width * 0.2f, Screen.height / 2, 200f, 40f), "WRÓĆ"))
            {
                Wroc();
            }
            if (GUI.Button(new Rect(Screen.width * 0.2f, Screen.height / 2 + 50f, 200f, 40f), "MENU"))
            {
                MenuWroc();
            }
        }
    }
}
