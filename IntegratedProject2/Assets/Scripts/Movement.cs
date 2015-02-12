using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 7.0f;
	public float jumpForce = 200.0f;
	public Transform groundCheck;
	public LayerMask groundMask;
	private float groundRadius = 0.3f;
	private bool grounded = false;
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
			}
			
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		//check if groundcheck object touches collider
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, groundMask);

		//moves the player in a straight line
		rigidbody2D.AddForce (new Vector2(speed, 0.0f));

	
	}
}
