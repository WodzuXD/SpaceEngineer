using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Zlecenia : MonoBehaviour
{

    public int zlecenia;
    public bool przyjete = false;

    public GameObject canvas;

    public bool scena = false;

    Zlecenia zla;
    public List<Zlecenia> zl = new List<Zlecenia>();
    public List<dousunecia> pod = new List<dousunecia>();

    bool dodawanie = false;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(canvas);
    }

    private void Update()
    {
        zla = FindObjectOfType<Zlecenia>();
        if (SceneManager.sceneCount != 1)
            scena = true;
        if (SceneManager.sceneCount == 1 && scena)
        {
            for (int i = 0; i < zl.Count; i++)
            {
                Destroy(zl[i].gameObject);
                zl.Remove(zl[i]);
            }
            for (int i = 0; i < pod.Count; i++)
            {
                Destroy(pod[i].gameObject);
                pod.Remove(pod[i]);
            }
        }
        if (SceneManager.sceneCount == 1 && !scena && !dodawanie)
            if (zla.scena)
                 zla.zl.Add(gameObject.transform.GetComponent<Zlecenia>()); dodawanie = true;
        
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
