using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	public bool shield = false;
	public int powerUpTimer;

	// Use this for initialization
	void Start () {


	
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
			//gameObject.collider2D.isTrigger = true;
			//gameObject.layer = 14;
			Destroy(other.gameObject);
		}
	}

	IEnumerator PowerUpMethod(){
        if (shield == true)
        {
            yield return new WaitForSeconds(powerUpTimer);
            Debug.Log("end shield");
            //gameObject.collider2D.isTrigger = false;
            shield = false;
        }		
			
	}
}
