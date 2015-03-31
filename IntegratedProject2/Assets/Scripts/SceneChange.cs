using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneChange : MonoBehaviour {

    public GameObject pauseMenu;
    public GameObject displayTimeText;
    public Text currentTime;


    void Start()
    {
        currentTime = displayTimeText.gameObject.GetComponent<Text>();
        currentTime.text = "Time Running: " + Time.timeSinceLevelLoad.ToString("0.0") + " Seconds";
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
