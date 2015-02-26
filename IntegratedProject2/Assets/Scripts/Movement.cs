using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 7.0f;
	public float maxSpeed = 25.0f;
	public float jumpForce = 300.0f;
	public float altJumpForce = 10.0f;
	public float airRes = 20.0f;
	public Transform groundCheck;
	public LayerMask groundMask;
	public float groundRadius = 0.2f;
	private bool grounded;
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

	void Update()
	{

		if(grounded)
		{
			Debug.Log ("true");
		}

		//checks button input
		if(Input.GetButtonDown("Jump") && grounded == true)
		{
			//checks if player is grounded before jumping
				grounded = false;
				Debug.Log ("false");
				rigidbody2D.AddForce (new Vector2(0.0f, jumpForce));
				//rigidbody2D.AddForce (new Vector2(-airRes, 0.0f));
	
			
		}

		if(Input.touchCount == 1)
		{
			//checks if player is grounded before jumping
			if(grounded)
			{
				grounded = false;
				rigidbody2D.AddForce (new Vector2(0.0f, altJumpForce));
				//rigidbody2D.AddForce (new Vector2(-airRes, 0.0f));
			}

		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		//check if groundcheck object touches collider
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, groundMask);

		//moves the player in a straight line
		//rigidbody2D.AddForce (new Vector2(speed, 0.0f));

		if(grounded == true && rigidbody2D.velocity.magnitude < maxSpeed)
		{
			rigidbody2D.AddForce (new Vector2(speed, 0.0f));
		}
		

	
	}
}
