using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject[] items;
	public float minSpawn = 1.0f;
	public float maxSpawn = 2.0f;

	// Use this for initialization
	void Start () {

		SpawnBehaviour();
	
	}

	void SpawnBehaviour()
	{
		Instantiate(items[Random.Range (0, items.Length)], transform.position, Quaternion.identity);
		Invoke("SpawnBehaviour", Random.Range (minSpawn, maxSpawn));
	}

}
