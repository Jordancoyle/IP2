using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 7.0f;
	public float jumpForce = 300.0f;
	public float andJumpForce = 100;
	public float airRes = 20.0f;
	public Transform groundCheck;
	public LayerMask groundMask;
	private float groundRadius = 0.2f;
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

	void Update()
	{
		//checks button input
		if(Input.GetButtonDown("Jump"))
		{
			//checks if player is grounded before jumping
			if(grounded)
			{
				grounded = false;
				rigidbody2D.AddForce (new Vector2(0.0f, jumpForce));
				//rigidbody2D.AddForce (new Vector2(-airRes, 0.0f));
			}
			
		}

		if(Input.touchCount == 1)
		{
			//checks if player is grounded before jumping
			if(grounded)
			{
				grounded = false;
				rigidbody2D.AddForce (new Vector2(0.0f, andJumpForce));
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

		if(grounded)
		{
			rigidbody2D.AddForce (new Vector2(speed, 0.0f));
		}
		

	
	}
}
