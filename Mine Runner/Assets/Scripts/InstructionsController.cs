﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsController : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnStart()
    {
        GameController.amountOfPlatforms = 0;
        GameController.score = 0;
        if (GameController.gameType == -1 || GameController.gameType == 100)
        {
            SceneManager.LoadScene("Game");
        } else
        {
            SceneManager.LoadScene("Challenge100");
        }
        
    }
}
