using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 7.0f;
	public float jumpForce = 20.0f;
	private bool grounded = true;
	//private Touch touch;

	// Use this for initialization
	void Start () {

	
	}
	//to be developed
	/*void Update()
	{
		if(Input.touchCount == 1)
		{
			touch = Input.GetTouch(0);
		}
		if (touch.phase == TouchPhase.Began)
		{
			if(grounded)
			{
				rigidbody2D.AddForce (new Vector2(0.0f, jumpForce));
				grounded = true;
			}
		}
	}*/

	// Update is called once per frame
	void FixedUpdate () {

		//moves the player in a straight line
		rigidbody2D.velocity = new Vector2(speed, 0.0f);

		//checks button input
		if(Input.GetButtonDown("Jump"))
		{
			//checks if player is grounded before jumping
			if(grounded)
			{
			    rigidbody2D.AddForce (new Vector2(0.0f, jumpForce));
				grounded = true;
			}

		}

	
	}
}
