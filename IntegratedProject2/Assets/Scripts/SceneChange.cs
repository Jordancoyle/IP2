using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

    public GameObject pauseMenu;

    void Start()
    {

    }

	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}

	public void ExitGame()
	{
		Application.Quit();
	}

    public void Settings()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
