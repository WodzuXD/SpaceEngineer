using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wykorzystanie : MonoBehaviour {

    public enum PrzedmiotEnum { wkrentarka,spawarka,gasnica,zbiornik,szyba,plaski}
    public PrzedmiotEnum rodzajPrzedmiotu;

    

    public AudioSource welder;
    public AudioSource wkrentarka;
    public AudioSource gasnica;
    public AudioSource zbiornik;
    public AudioSource szyba;
    public AudioSource plaski;

    public Animator animWkrent;
    public Animator animPlaski;
    public GameObject spawarkaPartic;
    public GameObject gasnicaPartic;

    float Timer = 0f;

	void Start () {
		
	}

    void Update() {

        Timer += Time.deltaTime;

        if (Timer >= 0.1f && Input.GetMouseButton(1))
        { 
            Strzal();
            Timer = 0;
        }
        switch (rodzajPrzedmiotu)
            {
                case PrzedmiotEnum.spawarka:
                if (Input.GetMouseButton(1))
                {
                    spawarkaPartic.active = true;
                    welder.mute = false;
                }
                else
                {
                    welder.mute = true;
                    spawarkaPartic.active = false;
                }

                break;
                case PrzedmiotEnum.wkrentarka:
                if (Input.GetMouseButton(1))
                {
                    wkrentarka.mute = false;
                    animWkrent.SetBool("dziala", true);
                }
                else
                {
                    wkrentarka.mute = true;
                    animWkrent.SetBool("dziala", false);
                }
                break;
            case PrzedmiotEnum.gasnica:
                if (Input.GetMouseButton(1))
                {
                    gasnicaPartic.active = true;
                    gasnica.mute = false;
                }
                else
                {
                    gasnica.mute = true;
                    gasnicaPartic.active = false;
                }
                break;
            case PrzedmiotEnum.plaski:
                if (Input.GetMouseButton(1))
                {
                    plaski.mute = false;
                    //animPlaski.SetBool("dziala", true);
                }
                else
                {
                    plaski.mute = true;
                    //animPlaski.SetBool("dziala", false);
                }
                break;
            case PrzedmiotEnum.zbiornik:
                if (Input.GetMouseButton(1))
                {
                    zbiornik.mute = false;
                }
                else
                {
                    zbiornik.mute = true;
                }
                break;
            case PrzedmiotEnum.szyba:
                if (Input.GetMouseButton(1))
                {
                    szyba.mute = false;
                }
                else
                {
                    szyba.mute = true;
                }
                break;
        }
	}

    void Strzal()
    {
        Ray promien = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        RaycastHit[] trafienia = Physics.RaycastAll(promien, 2f);

        foreach (RaycastHit hit in trafienia)
        {
            if (hit.transform.root != transform)
            {
                if (hit.transform.root.tag == "Dziura" && rodzajPrzedmiotu == PrzedmiotEnum.spawarka)
                {
                    hit.transform.GetComponent<Dziura>().hp -= 10;
                }
                if (hit.transform.root.tag == "szafka" && rodzajPrzedmiotu == PrzedmiotEnum.wkrentarka)
                {
                    if(hit.transform.GetComponent<Wkrenty>())
                        hit.transform.GetComponent<Wkrenty>().progress += 10f;
                    if(hit.transform.GetComponent<WkrentyPod>())
                        hit.transform.GetComponent<WkrentyPod>().progress += 10f;
                }
                if (hit.transform.root.tag == "ogien" && rodzajPrzedmiotu == PrzedmiotEnum.gasnica)
                {
                    hit.transform.GetComponent<Ogien>().hp -= 50;
                }
                if (hit.transform.root.tag == "zaslepka" && rodzajPrzedmiotu == PrzedmiotEnum.plaski)
                {
                    //hit.transform.GetComponent<Ogien>().hp -= 50;
                }
                if (hit.transform.root.tag == "mSzyba" && rodzajPrzedmiotu == PrzedmiotEnum.szyba)
                {
                    //hit.transform.GetComponent<Ogien>().hp -= 50;
                    Statek statek = FindObjectOfType<Statek>();
                    statek.szyba = 1;
                    Inv inwentory = FindObjectOfType<Inv>();
                    inwentory.obiektWRence = 0;
                }
                if (hit.transform.root.tag == "mZbiornik" && rodzajPrzedmiotu == PrzedmiotEnum.zbiornik)
                {
                    Debug.Log("zbiornik");
                    hit.transform.GetComponent<Mzbiornik>().Zbiornik();
                    Statek statek = FindObjectOfType<Statek>();
                    statek.zbiornik = 1;
                    Inv inwentory = FindObjectOfType<Inv>();
                    inwentory.obiektWRence = 0;

                }
            }
        }
    }
}
