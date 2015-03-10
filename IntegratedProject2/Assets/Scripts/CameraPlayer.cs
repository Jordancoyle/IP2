using UnityEngine;
using System.Collections;

public class CameraPlayer : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(player.position.x + 23.30f, 0, -10);

	
	}

	void OnGUI(){
		GUI.Label (new Rect (Screen.width -80, 5, 100, 40), "Time : " + Time.timeSinceLevelLoad.ToString("0.0"));
	}


}
