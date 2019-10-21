using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dziura : MonoBehaviour {

    public bool demo = true;


    public int hp = 450;
    public SterowanieKokpitem sK;
    public Statek st;

	void Update () {
        if (hp <= 0) {
            if(demo){
                if (sK.dziury[0] == 0)
                {
                    if (sK.dziury[1] == 0)
                    {
                        sK.dziury[2] = 0;
                    }
                    else sK.dziury[1] = 0;
                }
                else sK.dziury[0] = 0;
                Destroy(gameObject);
            }
            if (!demo)
            {
                st.dziury -= 1;
                gameObject.active = false;
            }
        }
	}
}
