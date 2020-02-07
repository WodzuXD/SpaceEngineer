using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dziura : MonoBehaviour {

    public int hp = 450;
    public Statek st;

	void Update () {
        if (hp <= 0) {
            st.dziury -= 1;
            gameObject.active = false;
        }
	}
}
