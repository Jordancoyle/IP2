using UnityEngine;
using System.Collections;

public class CamaraFollow : MonoBehaviour {

	public Transform pla;

	// Use this for initialization
	void Start () {

		//pla = GameObject.Find("Player");
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(player.position.x + 6, 0, -10);
	
	}
}
