using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSize : MonoBehaviour {
    BoxCollider2D m_Collider;
    public GameObject player; 
    public float m_ScaleY, m_ScaleX;
    public float changesize_y;
    bool interruptor;
    // Use this for initialization
    void Start () {
        m_Collider = gameObject.GetComponent<BoxCollider2D>();
        interruptor = false;
        //player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if (player.gameObject.GetComponent<Animator>().GetBool("onFloor") && player.GetComponent<Animator>().GetBool("dash") && !player.GetComponent<Animator>().GetBool("onDash"))
        {
            m_Collider.size = new Vector3(m_ScaleX, m_ScaleY+changesize_y);
            interruptor = true;
        }
        else if (player.gameObject.GetComponent<Animator>().GetBool("onFloor") && player.GetComponent<Animator>().GetBool("dash") && player.GetComponent<Animator>().GetBool("onDash"))
        {
            m_Collider.size = new Vector3(m_ScaleX, m_ScaleY + changesize_y);
            interruptor = true;
        }
        else if (!player.gameObject.GetComponent<Animator>().GetBool("onFloor"))
        {
            m_Collider.size = new Vector3(m_ScaleX, m_ScaleY);
            interruptor = false;
        }
        */
        if (player.gameObject.GetComponent<Animator>().GetBool("onFloor") && player.GetComponent<Animator>().GetBool("onDash"))
        {
            m_Collider.size = new Vector3(m_ScaleX, m_ScaleY + changesize_y);
        }
        else if (!player.gameObject.GetComponent<Animator>().GetBool("onFloor") || Input.anyKey)
        {
            m_Collider.size = new Vector3(m_ScaleX, m_ScaleY);
        }
    }
}
