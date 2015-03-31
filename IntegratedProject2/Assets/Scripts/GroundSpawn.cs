using UnityEngine;
using System.Collections;

public class GroundSpawn : MonoBehaviour {

    public GameObject[] ground;
    public GameObject lul;
    public GameObject lastGround;
    float groundWidth;
    float groundHeight;
    Vector3 lastPosition = new Vector3(0,0,0);
    Vector3 offset = new Vector3(3.459999f,0,0);

    void Start()
    {

        lastPosition = lastGround.transform.position;
        groundWidth = lul.renderer.bounds.size.x;
        groundHeight = lul.renderer.bounds.size.y;
        Debug.Log(groundWidth);
        Debug.Log(groundHeight);

    }

    void Update()
    {
        GameObject myPrefabInstance = Instantiate(ground[Random.Range(0,ground.Length)], lastPosition + offset, Quaternion.identity) as GameObject;
        lastPosition = myPrefabInstance.transform.position;
    }
}
