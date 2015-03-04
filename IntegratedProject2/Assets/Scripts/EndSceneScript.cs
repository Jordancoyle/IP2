using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndSceneScript : MonoBehaviour {

	public Text timePlayed;

	// Use this for initialization
	void Start () {

		timePlayed = gameObject.GetComponent<Text>();
		timePlayed.text = "Your time was: " + ((PermaObject) GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime.ToString () + " Seconds";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
