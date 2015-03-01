using UnityEngine;
using System.Collections;

public class DESTRUCTION : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{
		//inital player death
		if(other.tag == "Player")
		{
			Debug.Log("Ya'll is ded");
			return;

		}
		
		//checks if the object has a parent and destroys it
		if(other.gameObject.transform.parent)
		{
			Destroy(other.gameObject.transform.parent.gameObject);
		}
		else{
			Destroy(other.gameObject);
		}
	}
}
