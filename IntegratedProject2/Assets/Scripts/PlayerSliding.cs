using UnityEngine;
using System.Collections;

public class PlayerSliding : MonoBehaviour {

	public float slideFriction = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetButton("Slide"))
		{
			gameObject.layer = 10;
			if(rigidbody2D.velocity.magnitude > 0.0f)
			{
				rigidbody2D.AddForce(new Vector2(-slideFriction, 0.0f));
			}
		}
		else{
			gameObject.layer = 0;
		}

	
	}
}
