using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public float obstacleSlowDown = 20.0f;

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
            rigidbody2D.AddForce(new Vector2(-obstacleSlowDown, 0.0f));
            Destroy(collision.gameObject);

		}

        if (collision.gameObject.tag == "obsticle" && xshield == true)
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Death")
        {
            ((PermaObject)GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime = Time.timeSinceLevelLoad;
            Application.LoadLevel("EndScene");
        }
	}
}
