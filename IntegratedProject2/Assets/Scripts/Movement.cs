using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 7.0f;
	public float maxSpeed = 25.0f;
	public float jumpForce = 300.0f;
	public float altJumpForce = 50000.0f;
	public float airRes = 20.0f;
	//public Transform groundCheck;
	//public LayerMask groundMask;
	//public float groundRadius = 0.2f;
	public bool grounded = false;
    private Animator animator;
	//private Touch touch;
	public float distance;

	// Use this for initialization
	void Start () {

        animator = this.GetComponent<Animator>();
		CircleCollider2D circle = (CircleCollider2D)this.collider2D;
		distance = circle.radius + 0.5f;
	
	}

	void Update()
	{

		//checks button input
		if(Input.GetButtonDown("Jump") && grounded == true)
		{
			//checks if player is grounded before jumping
				grounded = false;
                animator.SetBool("isJumping", true);
				rigidbody2D.AddForce (new Vector2(0.0f, jumpForce));
				rigidbody2D.AddForce (new Vector2(-airRes, 0.0f));
	}
        else
        {
            animator.SetBool("isJumping", false);
        }
		/*
		if(Input.touchCount == 1)
		{
			//checks if player is grounded before jumping
			if(grounded == true)
			{
				grounded = false;
				rigidbody2D.AddForce (new Vector2(0.0f, altJumpForce));
				rigidbody2D.AddForce (new Vector2(-airRes, 0.0f));
			}

		}*/
	}

	// Update is called once per frame
	void FixedUpdate () {

		//check if groundcheck object touches collider
		//grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, groundMask);

		//moves the player in a straight line
		//rigidbody2D.AddForce (new Vector2(speed, 0.0f));
		//rigidbody2D.AddForce (new Vector2(speed, 0.0f));

        //Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit info;

        int mask = LayerMask.NameToLayer("Ground");

		grounded = Physics2D.Linecast (transform.position, transform.position + (Vector3.down * distance));
		Debug.DrawLine (transform.position, transform.position + (Vector3.down * distance));

		if(grounded == true && rigidbody2D.velocity.magnitude < maxSpeed)
		{
			rigidbody2D.AddForce (new Vector2(speed, 0.0f));
		}
		

	
	}
}
