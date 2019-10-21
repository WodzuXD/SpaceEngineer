using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SterowanieKokpitem : MonoBehaviour {

    public Light sw1;
    public Light sw2;

    public AudioSource musicNuc;
    public AudioSource musicTlo;
    public AudioSource normaMusic;

    public float timer;

    public int[] dziury;
    public int[] ogien;

    public Animator animDoor;

    bool zniszczenieKokpitu;

    bool zmniejsza = false;

    public bool zniszczenieStatku;

    public Color kolor1;
    public Color kolor2;

	void Start () {
		
	}
	
	void Update () {
        if(zmniejsza)
            timer -= Time.deltaTime;
        if(!zmniejsza)
            timer += Time.deltaTime;

        musicNuc.mute = !zniszczenieStatku;
        musicTlo.mute = !zniszczenieStatku;
        normaMusic.mute = zniszczenieStatku;


        if (timer < 0f)
            zmniejsza = false;
        if (timer > 5f)
            zmniejsza = true;

        if (dziury[0] == 0)
        {
            if (dziury[1] == 0)
            {
                if (dziury[2] == 0)
                {
                    zniszczenieKokpitu = false;
                }
                else zniszczenieKokpitu = true;
            }
            else zniszczenieKokpitu = true;
        }
        else zniszczenieKokpitu = true;

        if (ogien[0] == 0)
        {
            if (ogien[1] == 0)
            {
                if (ogien[2] == 0)
                {
                    if (ogien[3] == 0)
                    {
                        if (ogien[4] == 0)
                        {
                            if (ogien[5] == 0)
                            {
                                if (ogien[6] == 0)
                                {
                                    if (ogien[7] == 0)
                                    {
                                        if (ogien[8] == 0)
                                        {
                                            if (ogien[9] == 0)
                                            {
                                                if (ogien[10] == 0)
                                                {
                                                    if (ogien[11] == 0)
                                                    {
                                                        if (ogien[12] == 0)
                                                        {
                                                            if (ogien[13] == 0)
                                                            {
                                                                if (ogien[14] == 0)
                                                                {
                                                                    zniszczenieStatku = false;
                                                                }
                                                                else zniszczenieStatku = true;
                                                            }
                                                            else zniszczenieStatku = true;
                                                        }
                                                        else zniszczenieStatku = true;
                                                    }
                                                    else zniszczenieStatku = true;
                                                }
                                                else zniszczenieStatku = true;
                                            }
                                            else zniszczenieStatku = true;
                                        }
                                        else zniszczenieStatku = true;
                                    }
                                    else zniszczenieStatku = true;
                                }
                                else zniszczenieStatku = true;
                            }
                            else zniszczenieStatku = true;
                        }
                        else zniszczenieStatku = true;
                    }
                    else zniszczenieStatku = true;
                }
                else zniszczenieStatku = true;
            }
            else zniszczenieStatku = true;
        }
        else zniszczenieStatku = true;

        if (zniszczenieKokpitu)
        {
            animDoor.SetBool("otwarte", false);
        }
        if (!zniszczenieKokpitu)
        {
            animDoor.SetBool("otwarte", true);
        }

        if (zniszczenieStatku)
        {
            sw1.range = timer *10f;
            sw2.range = timer *10f;
            sw1.color = kolor1;
            sw2.color = kolor1;
            
        }
        else if (!zniszczenieStatku)
        {
            sw1.range =  10f;
            sw2.range =  10f;
            sw1.color = kolor2;
            sw2.color = kolor2;
        }
    }
}
