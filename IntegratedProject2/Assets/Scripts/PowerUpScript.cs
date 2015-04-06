using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	public bool shield = false;
    public bool slow = false;
	public int powerUpTimer;
    public int slowMotionTimer;
    public GameObject shieldObject;
    public GameObject shieldDisplay;
    public GameObject slowDisplay;
    public AudioClip puA;
    public AudioClip puB;

	// Use this for initialization
	void Start () {

        //shieldObject = GameObject.Find("/BigBerty/Shield");
 
	}

	void OnTriggerEnter2D(Collider2D other){

		//shield powerup
		if (other.gameObject.tag == "shield") {
			Debug.Log ("shield");
			shield = true;
            AudioSource.PlayClipAtPoint(puA, transform.position);
			StartCoroutine (PowerUpMethod ());
			Destroy(other.gameObject);
		}

        if(other.gameObject.tag == "Slow")
        {
            slow = true;
            AudioSource.PlayClipAtPoint(puB, transform.position);
			Destroy(other.gameObject);
			StartCoroutine(SlowMotion());
        }
     
	}

	IEnumerator PowerUpMethod()
	{
			shieldObject.gameObject.SetActive(true);
			shieldDisplay.gameObject.SetActive(true);
            yield return new WaitForSeconds(powerUpTimer);
            shieldObject.gameObject.SetActive(false);
            shieldDisplay.gameObject.SetActive(false);
            shield = false;
        	
	}

    IEnumerator SlowMotion()
    {
			Time.timeScale /= 2;
			Time.fixedDeltaTime /= 2;
			slowDisplay.gameObject.SetActive(true);
            yield return new WaitForSeconds(slowMotionTimer);
            Time.timeScale *= 2;
            Time.fixedDeltaTime *= 2;
            slowDisplay.gameObject.SetActive(false);
            slow = false;
    }
}
