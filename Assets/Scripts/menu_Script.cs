﻿using UnityEngine;
using System.Collections;

public class menu_Script : MonoBehaviour {

	public bool isset;
	public Texture2D atexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Start!"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Invoke("load",5);
			isset =true;

		}


		if (isset) {
			GUI.DrawTexture (new Rect ((Screen.width/2)-(450), (Screen.height/2)-(500), 931, 1024), atexture, ScaleMode.StretchToFill, true, 10.0F);
		}
	}

	public void load()
	{
		Application.LoadLevel ("test_Steven");
	}

}
