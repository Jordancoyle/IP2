using UnityEngine;
using System.Collections;

public class GroundSpawn : MonoBehaviour {

    public GameObject[] ground;
    public GameObject lastGround;
	public int dropChance = 10;
    Vector3 lastPosition = new Vector3(0,0,0);
    Vector3 offset = new Vector3(3.459999f,0,0);
	bool spawned = false;

    void Start()
    {

        lastPosition = lastGround.transform.position;

    }

    void Update()
    {
		GameObject myPrefabInstance;
		if (Random.Range (0, 100) <= dropChance && !spawned) {
			spawned = true;
			myPrefabInstance = Instantiate (ground [ground.Length - 1], lastPosition + offset, Quaternion.identity) as GameObject;
		} else {
			spawned = false;
			myPrefabInstance = Instantiate (ground [Random.Range (0, ground.Length - 1)], lastPosition + offset, Quaternion.identity) as GameObject;
		}

        lastPosition = myPrefabInstance.transform.position;
    }
}
