using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Texture2D backGroundTexture;
	int buttonX;
	int buttonY;
	
		void OnGUI(){
		
			buttonX = (Screen.width / 2);
			buttonY = (Screen.height / 2);
		
			//draws the background
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backGroundTexture);
			//draws the start button
			if (GUI.Button (new Rect (buttonX -50 , buttonY -80, 100, 30), "Start")) {
			
			//StartCoroutine(PlaySound());
			
			//Load the level
			Application.LoadLevel ("Scene1");
			
			}


			//draws the exit button
			if (GUI.Button (new Rect (buttonX -50, buttonY -30, 100, 30), "Rules")) {
			
			//StartCoroutine(PlaySound());
			
			//Load Rules Scene
			Application.LoadLevel("Rules Scene");
			
			}

		//draws the exit button
		if (GUI.Button (new Rect (buttonX -50, buttonY +20, 100, 30), "Exit")) {
			
			//StartCoroutine(PlaySound());
			
			//exit the level
			Application.Quit ();
			
		}

		//draws the exit button
		if (GUI.Button (new Rect (Screen.width - 150, Screen.height -80, 100, 30), "Mute")) {
			
			//StartCoroutine(PlaySound());
			
			Debug.Log("mute");
			
		}

		}
	}
