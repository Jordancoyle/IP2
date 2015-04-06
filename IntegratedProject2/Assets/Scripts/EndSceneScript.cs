using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndSceneScript : MonoBehaviour {

	public Text timePlayed;
    public AudioClip click;

	// Use this for initialization
	void Start () {

		timePlayed = gameObject.GetComponent<Text>();
		timePlayed.text = "Your time was: " + ((PermaObject) GameObject.Find("PermaObject").GetComponent(typeof(PermaObject))).killTime.ToString ("0.00") + " Seconds";
	
	}

    public void ChangeScene(string sceneName)
    {
        AudioSource.PlayClipAtPoint(click, transform.position);
        Application.LoadLevel(sceneName);
    }

    public void ExitGame()
    {
        AudioSource.PlayClipAtPoint(click, transform.position);
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
