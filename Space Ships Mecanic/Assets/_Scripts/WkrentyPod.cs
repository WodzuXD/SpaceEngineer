using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WkrentyPod : MonoBehaviour
{
    public float progress = 0f;
    public float endDrill = 1f;

    public GameObject srobaGO;
    public ShipPod pS;

    float last;


    void Start()
    {

    }

    void Update()
    {


        if (progress != last)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, gameObject.transform.position -= new Vector3(0f, 0.002f * progress, 0f), Time.deltaTime * 10f);
            last = progress;
        }

        if (progress >= endDrill)
        {
            if (pS.srobypod[0] == 0)
            {
                if (pS.srobypod[1] == 0)
                {
                    if (pS.srobypod[2] == 0)
                    {
                        pS.srobypod[3] = 0;
                    }
                    else pS.srobypod[2] = 0;
                }
                else pS.srobypod[1] = 0;
            }
            else pS.srobypod[0] = 0;

            GameObject obiekt = Instantiate(srobaGO, gameObject.transform.position, gameObject.transform.rotation) as GameObject;

            gameObject.active = false;
        }
    }
}
