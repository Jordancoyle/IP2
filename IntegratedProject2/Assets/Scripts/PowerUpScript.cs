using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	public bool shield = false;
	public int powerUpTimer;
    public GameObject shieldObject;
    public GameObject shieldDisplay;

	// Use this for initialization
	void Start () {

        //shieldObject = GameObject.Find("/BigBerty/Shield");
 
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (PowerUpMethod ());
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
	}

	IEnumerator PowerUpMethod(){
        if (shield == true)
        {
            yield return new WaitForSeconds(powerUpTimer);
            Debug.Log("end shield");
            shield = false;
        }
        else
        {
            shieldObject.gameObject.SetActive(false);
            shieldDisplay.gameObject.SetActive(false);
        }
			
	}
}
