using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float high = 0.1f;
    public GameObject player;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        // gameObject.transform.Translate(-1 * GameControl.instance.scrollSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey("up") || Input.GetKey(KeyCode.W) && player.gameObject.transform.position.y > -2.20)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f * Time.deltaTime));
            player.gameObject.GetComponent<Animator>().SetBool("onFloor", false);
        }
        else if(player.gameObject.transform.position.y <= -2.20)
        {
            player.gameObject.GetComponent<Animator>().SetBool("onFloor", true);

        }

        if (Input.GetKey("down") || Input.GetKey(KeyCode.S) && player.gameObject.GetComponent<Animator>().GetBool("onFloor") && player.gameObject.transform.position.y != -2.81f)
        {
            player.gameObject.GetComponent<Animator>().SetBool("dash", true);
            player.gameObject.GetComponent<Animator>().SetBool("onDash", false);

        }
        else if (Input.GetKey("down") || Input.GetKey(KeyCode.S) &&  player.gameObject.GetComponent<Animator>().GetBool("dash") && !player.gameObject.GetComponent<Animator>().GetBool("onDash"))
        {
            player.gameObject.GetComponent<Animator>().SetBool("dash", false);
            player.gameObject.GetComponent<Animator>().SetBool("onDash", true);
            player.gameObject.transform.position = new Vector3(0, -2.81f, 0);
        }
       /* else if (player.gameObject.GetComponent<Animator>().GetBool("onFloor"))
        {
            player.gameObject.GetComponent<Animator>().SetBool("dash", false);
            player.gameObject.GetComponent<Animator>().SetBool("onDash", false);
            player.gameObject.transform.position = new Vector3(0, -2.2f, 0);
        }*/

        if (Input.GetKey(KeyCode.Space) && !player.gameObject.GetComponent<Animator>().GetBool("fire") && player.gameObject.GetComponent<Animator>().GetBool("onFloor"))
        {
            player.gameObject.GetComponent<Animator>().SetBool("fire", true);
        }
        else if (player.gameObject.GetComponent<Animator>().GetBool("fire") && player.gameObject.GetComponent<Animator>().GetBool("onFloor"))
        {
            player.gameObject.GetComponent<Animator>().SetBool("fire", false);
        }

        if (Input.GetKey(KeyCode.Space) && !player.gameObject.GetComponent<Animator>().GetBool("fire") && !player.gameObject.GetComponent<Animator>().GetBool("onFloor"))
        {
            player.gameObject.GetComponent<Animator>().SetBool("fire", true);
        }
        else if (player.gameObject.GetComponent<Animator>().GetBool("fire") && !player.gameObject.GetComponent<Animator>().GetBool("onFloor"))
        {
            player.gameObject.GetComponent<Animator>().SetBool("fire", false);
        }
        if (player.gameObject.GetComponent<Animator>().GetFloat("life") < 1f)
        {
            player.gameObject.GetComponent<Animator>().SetFloat("fire", 0.001f);
        }
    }
}

