using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject pauseMenu;
	bool paused = false;

	void Update()
	{
		if(Input.GetButtonDown ("Pause"))
		{
			if(paused == true)
			{
				Time.timeScale = 1.0f;
				pauseMenu.gameObject.SetActive(false);
				paused = false;
			}

			else{
				Time.timeScale = 0.0f;
				pauseMenu.gameObject.SetActive(true);
				paused = true;
			}
		}
	}

	public void Resume()
	{
		Time.timeScale = 1.0f;
		pauseMenu.gameObject.SetActive(false);
	}

	public void ReturnToMainMenu()
	{
		Time.timeScale = 1.0f;
		Application.LoadLevel ("MainMenuScene");
	}

}
