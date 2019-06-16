using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float high = 0.1f;
    public GameObject player;
    private bool isCoroutineExecuting = false;
    Collision collision;


    // Use this for initialization
    void Start()
    {
        collision = player.gameObject.GetComponent<Collision>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
                if ((Input.GetKey("up") || Input.GetKey(KeyCode.W)) && collision.particiel == false) //SIN GRAVEDAD INVERTIDA
                {
                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f * Time.deltaTime));
                    player.gameObject.GetComponent<Animator>().SetBool("onFloor", false);
                    player.gameObject.GetComponent<Animator>().SetBool("onDash", false);
                }
                else if ((Input.GetKey("down") || Input.GetKey(KeyCode.S)) && player.gameObject.transform.position.y <= -2.06 && collision.particiel == false)
                {
                    player.gameObject.GetComponent<Animator>().SetBool("onFloor", true);
                }

                if ((Input.GetKey("down") || Input.GetKey(KeyCode.S)) && collision.particiel == true) //CON GRAVEDAD INVERTIDA
                {
                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1000f * Time.deltaTime));
                    player.gameObject.GetComponent<Animator>().SetBool("onFloor", false);
                    player.gameObject.GetComponent<Animator>().SetBool("onDash", false);
                }
                else if ((Input.GetKey("up") || Input.GetKey(KeyCode.W)) && player.gameObject.transform.position.y <= -2.06 && collision.particiel == true)
                {
                    player.gameObject.GetComponent<Animator>().SetBool("onFloor", true);
                }
        */
        if ((Input.GetKey("up") || Input.GetKey(KeyCode.W)) && collision.particiel == false) //SIN GRAVEDAD INVERTIDA
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f * Time.deltaTime));
        }
        if ((Input.GetKey("down") || Input.GetKey(KeyCode.S)) && collision.particiel == true) //CON GRAVEDAD INVERTIDA
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1000f * Time.deltaTime));
        }

        /*
                if ((Input.GetKey("down") || Input.GetKey(KeyCode.S)) && player.gameObject.GetComponent<Animator>().GetBool("onFloor") && collision.particiel == false)
                {
                    player.gameObject.GetComponent<Animator>().SetBool("onDash", true);
                }
                if ((Input.GetKey("up") || Input.GetKey(KeyCode.W)) && player.gameObject.GetComponent<Animator>().GetBool("onFloor") && collision.particiel == true)
                {
                    player.gameObject.GetComponent<Animator>().SetBool("onDash", true);
                }
        */

        if ((Input.GetKey("down") || Input.GetKey(KeyCode.S)) && player.gameObject.GetComponent<Animator>().GetBool("onFloor") && collision.particiel == false)
        {
            player.gameObject.GetComponent<Animator>().SetBool("onDash", true);
        }
        else if ((!Input.anyKey || Input.GetKey("up") || Input.GetKey(KeyCode.W)) && collision.particiel == false)
        {
            player.gameObject.GetComponent<Animator>().SetBool("onDash", false);
        }

        if ((Input.GetKey("up") || Input.GetKey(KeyCode.W)) && player.gameObject.GetComponent<Animator>().GetBool("onFloor") && collision.particiel == true)
        {
            player.gameObject.GetComponent<Animator>().SetBool("onDash", true);
        }
        else if ((!Input.anyKey || Input.GetKey("down") || Input.GetKey(KeyCode.S)) && collision.particiel == true)
        {
            player.gameObject.GetComponent<Animator>().SetBool("onDash", false);
        }

        if (Input.GetKey("escape")) //FINALIZAR JUEGO
        {
            Debug.Log("has quit game");
            Application.Quit();
        }


        /* //NO ES IMPORTANTE
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
        */
    }

}