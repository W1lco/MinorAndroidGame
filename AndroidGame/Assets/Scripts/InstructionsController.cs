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

    void OnMouseUp()
    {
        switch (gameObject.tag)
        {
            case "BackToMenu":
                SceneManager.LoadScene("Menu");
                break;
            case "Play":
                SceneManager.LoadScene("Game");
                break;
            default:
                break;
        }
    }
}
