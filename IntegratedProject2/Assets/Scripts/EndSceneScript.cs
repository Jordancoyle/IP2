using UnityEngine;
using System.Collections;

public class EndSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		float time = ((PermaObject) GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime;

		GUI.Label (new Rect ((Screen.width/2)-50, (Screen.height/2)- 20, 200, 40), "You Ran For " + time.ToString("0.0") + " Seconds");

	}
}
