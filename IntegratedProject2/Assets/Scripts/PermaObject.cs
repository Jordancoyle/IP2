using UnityEngine;
using System.Collections;

public class PermaObject : MonoBehaviour {

	public float killTime;

	// Use this for initialization
	void Start () {

		DontDestroyOnLoad (this);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
