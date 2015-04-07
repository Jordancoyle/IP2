using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public AudioClip death;
    public float obstacleSlowDown = 20.0f;
    public GameObject player;
   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator DeathClip()
    {
        AudioSource.PlayClipAtPoint(death, transform.position);
        yield return new WaitForSeconds(death.length);
        ((PermaObject)GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime = Time.timeSinceLevelLoad;
        Application.LoadLevel("EndScene");
    }

	void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		PowerUpScript pus = player.GetComponent<PowerUpScript>();
		bool xshield = pus.shield;

		//kill player
		if (collision.gameObject.tag == "obsticle" && !xshield) {

			Debug.Log ("obstacle hit");
            if(rigidbody2D.velocity.magnitude > 0.0f)
            {
                rigidbody2D.AddForce(new Vector2(-obstacleSlowDown, 0.0f));
            }
            Destroy(collision.gameObject);

		}

        if (collision.gameObject.tag == "obsticle" && xshield == true)
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Death")
        {
            StartCoroutine(DeathClip());
        }

	}
}
