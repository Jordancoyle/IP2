﻿using UnityEngine;
using System.Collections;

public class PlayerSliding : MonoBehaviour {

	public float slideFriction = 2.0f;
    private Animator animator;

	// Use this for initialization
	void Start () {

        animator = this.GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        bool isUp = Input.GetButtonUp("Slide");

        if (isUp)
        {
            Debug.Log("Up");
            gameObject.layer = 0;
            animator.SetBool("isSliding", false);
            animator.SetBool("isRunning", true);
        }

		if (Input.GetButtonDown("Slide")) {

			gameObject.layer = 10;
			animator.SetBool ("isSliding", true);
			if (rigidbody2D.velocity.magnitude > 0.0f) {
				rigidbody2D.AddForce (new Vector2 (-slideFriction, 0.0f));
			}

		

	
	}
}
}
