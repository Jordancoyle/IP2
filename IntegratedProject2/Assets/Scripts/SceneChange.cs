using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {


	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
