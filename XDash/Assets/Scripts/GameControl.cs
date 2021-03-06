﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public Canvas canvas;
    public float scrollSpeed;

    //For initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            canvas.gameObject.SetActive(false);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update () {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }	
	}

    public void PlayerDied()
    {
        canvas.gameObject.SetActive(true);
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
