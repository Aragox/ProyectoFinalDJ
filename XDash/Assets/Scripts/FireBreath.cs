using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBreath : MonoBehaviour {

    public Transform fireball;
    public GameObject blastPrefav;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)){
            fireblast();
        }
	}

    void fireblast() {
        Instantiate(blastPrefav, fireball.position, fireball.rotation);
    }
}
