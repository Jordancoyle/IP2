using UnityEngine;
using System.Collections;

public class PlayerSliding : MonoBehaviour {

	public float slideFriction = 2.0f;
    public AudioClip slide;
    public Animation animSlide;
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
            animator.enabled = true;
            //animator.SetBool("isSliding", false);
           //animator.SetBool("isRunning", true);
        }

		if (Input.GetButtonDown("Slide")) {

            Debug.Log("down");
            AudioSource.PlayClipAtPoint(slide, transform.position);
			gameObject.layer = 10;
            animator.enabled = false;
            animation.Play("Berty_Slide");
            animation.wrapMode = WrapMode.Once;
			//animator.SetBool ("isSliding", true);
			if (rigidbody2D.velocity.magnitude > 0.0f) {
				rigidbody2D.AddForce (new Vector2 (-slideFriction, 0.0f));
			}

		

	
	}
}
}
