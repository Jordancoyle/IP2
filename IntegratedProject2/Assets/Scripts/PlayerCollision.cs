using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	

	void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		PowerUpScript pus = player.GetComponent<PowerUpScript>();
		bool xshield = pus.shield;

		//kill player
		if (collision.gameObject.tag == "obsticle" && !xshield) {
			Debug.Log ("obsticle hit");
			((PermaObject) GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime = Time.timeSinceLevelLoad;

			Application.LoadLevel("EndScene");

		}

        if (collision.gameObject.tag == "obsticle" && xshield == true)
        {
            //collision.gameObject.SetActive(false);
            //Physics2D.IgnoreCollision(playerCollider, collision.collider);
            Destroy(collision.gameObject);
        }
	}
}
