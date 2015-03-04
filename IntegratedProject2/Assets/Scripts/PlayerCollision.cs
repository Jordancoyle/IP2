using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	bool shield = false;
	public int powerUpTimer;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (PowerUpMethod ());
	
	}

	IEnumerator PowerUpMethod(){
		if (shield == true) {
			yield return new WaitForSeconds(powerUpTimer);
			Debug.Log ("end shield");
			shield = false;
			gameObject.layer = 0;


		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		//shield powerup
		if (collision.gameObject.tag == "shield") {
			Debug.Log ("shield");
			shield = true;
			gameObject.layer = 10;
			Destroy(collision.gameObject);
		}


		//kill player
		if (collision.gameObject.tag == "obsticle" && !shield) {
			Debug.Log ("obsticle hit");
			((PermaObject) GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime = Time.timeSinceLevelLoad;

			Application.LoadLevel("EndScene");

		}
	}
}
