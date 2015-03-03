using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour {

	public GameObject[] lowDanger;
	public GameObject[] medDanger;
	public GameObject[] highDanger;
	public float minSpawn = 15.0f;
	public float maxSpawn = 20.0f;
	public float lowTime;
	public float medTime;
	public float highTime;

	private bool lowSpawning = false, medSpawning = false, highSpawning = false;
	
	// Use this for initialization
	void Start () {
		Debug.Log ("Spawning Start");
	}
	
	void LowSpawn()
	{
		Instantiate(lowDanger[Random.Range (0, lowDanger.Length)], transform.position, Quaternion.identity);
		Invoke("LowSpawn", Random.Range (minSpawn, maxSpawn));
	}

	void MedSpawn()
	{
		Instantiate(medDanger[Random.Range (0, medDanger.Length)], transform.position, Quaternion.identity);
		Invoke("MedSpawn", Random.Range (minSpawn, maxSpawn));
	}

	void HighSpawn()
	{
		Instantiate(highDanger[Random.Range (0, highDanger.Length)], transform.position, Quaternion.identity);
		Invoke("HighSpawn", Random.Range (minSpawn, maxSpawn));
	}

	void Update()
	{
		if (!lowSpawning && Time.timeSinceLevelLoad > lowTime && Time.timeSinceLevelLoad < medTime)
		{
			LowSpawn();
			lowSpawning = true;
		}

		if (!medSpawning && Time.timeSinceLevelLoad > medTime && Time.timeSinceLevelLoad < highTime)
		{
			MedSpawn();
			medSpawning = true;
		}
		
		if(!highSpawning && Time.timeSinceLevelLoad > highTime)
		{
			HighSpawn();
			highSpawning = true;
		}
	}
}
