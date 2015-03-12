﻿using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	

	void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject player = GameObject.Find("Player");
		PowerUpScript pus = player.GetComponent<PowerUpScript>();
		bool xshield = pus.shield;

		//kill player
		if (collision.gameObject.tag == "obsticle" && !xshield) {
			Debug.Log ("obsticle hit");
			((PermaObject) GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime = Time.timeSinceLevelLoad;

			Application.LoadLevel("EndScene");

		}
	}
}
