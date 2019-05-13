using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        // gameObject.transform.Translate(-1 * GameControl.instance.scrollSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f * Time.deltaTime));
        }
	}
}

