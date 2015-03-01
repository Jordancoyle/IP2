using UnityEngine;
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
		//kill player
		if (collision.gameObject.tag == "obsticle") {
			Debug.Log ("obsticle hit");
			((PermaObject) GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime = Time.timeSinceLevelLoad;

			Application.LoadLevel("EndScene");

		}
	}
}
