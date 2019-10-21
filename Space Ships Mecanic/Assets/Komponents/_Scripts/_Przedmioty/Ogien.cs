using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogien : MonoBehaviour {

    public int hp = 450;
    public SterowanieKokpitem sK;

    void Update()
    {
        if (hp <= 0)
        {
            if (sK.ogien[0] == 0)
            {
                if (sK.ogien[1] == 0)
                {
                    if (sK.ogien[2] == 0)
                    {
                        if (sK.ogien[3] == 0)
                        {
                            if (sK.ogien[4] == 0)
                            {
                                if (sK.ogien[5] == 0)
                                {
                                    if (sK.ogien[6] == 0)
                                    {
                                        if (sK.ogien[7] == 0)
                                        {
                                            if (sK.ogien[8] == 0)
                                            {
                                                if (sK.ogien[9] == 0)
                                                {
                                                    if (sK.ogien[10] == 0)
                                                    {
                                                        if (sK.ogien[11] == 0)
                                                        {
                                                            if (sK.ogien[12] == 0)
                                                            {
                                                                if (sK.ogien[13] == 0)
                                                                {
                                                                    if (sK.ogien[14] == 0)
                                                                    {
                                                                        sK.ogien[15] = 0;
                                                                    }
                                                                    else sK.ogien[14] = 0;
                                                                }
                                                                else sK.ogien[13] = 0;
                                                            }
                                                            else sK.ogien[12] = 0;
                                                        }
                                                        else sK.ogien[11] = 0;
                                                    }
                                                    else sK.ogien[10] = 0;
                                                }
                                                else sK.ogien[9] = 0;
                                            }
                                            else sK.ogien[8] = 0;
                                        }
                                        else sK.ogien[7] = 0;
                                    }
                                    else sK.ogien[6] = 0;
                                }
                                else sK.ogien[5] = 0;
                            }
                            else sK.ogien[4] = 0;
                        }
                        else sK.ogien[3] = 0;
                    }
                    else sK.ogien[2] = 0;
                }
                else sK.ogien[1] = 0;
            }
            else sK.ogien[0] = 0;
            Destroy(gameObject);
        }
    }
}
