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

	// Use this for initialization
	void Start () {

        //shieldObject = GameObject.Find("/BigBerty/Shield");
 
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (PowerUpMethod ());
        StartCoroutine(SlowMotion());
	}

	void OnTriggerEnter2D(Collider2D other){

		//shield powerup
		if (other.gameObject.tag == "shield") {
			Debug.Log ("shield");
			shield = true;
            shieldObject.gameObject.SetActive(true);
            shieldDisplay.gameObject.SetActive(true);
			Destroy(other.gameObject);
		}

        if(other.gameObject.tag == "Slow")
        {
            slow = true;
            Time.timeScale = 0.5f;
            //Time.fixedDeltaTime = 0.5f * 0.02f;
            slowDisplay.gameObject.SetActive(true);
            Destroy(other.gameObject);
        }
     
	}

	IEnumerator PowerUpMethod(){
        if (shield == true)
        {
            yield return new WaitForSeconds(powerUpTimer);
            shieldObject.gameObject.SetActive(false);
            shieldDisplay.gameObject.SetActive(false);
            shield = false;
        }
        	
	}

    IEnumerator SlowMotion()
    {
        if (slow)
        {
            yield return new WaitForSeconds(slowMotionTimer);
            Time.timeScale = 1.0f;
            //Time.fixedDeltaTime = 0.02f;
            slowDisplay.gameObject.SetActive(false);
            slow = false;
        }
    }
}
