using UnityEngine;
using System.Collections;

public class CameraPlayer : MonoBehaviour {

	public Transform player;
	public float cameraPosition = 20.0f;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(player.position.x + cameraPosition, 0, -10);
	
	}


}
