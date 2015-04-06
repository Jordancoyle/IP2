using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneChange : MonoBehaviour {

    public GameObject pauseMenu;
    public GameObject displayTimeText;
    public AudioClip click;
    public Text currentTime;

    void Start()
    {
        
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

    public void Settings()
    {
        pauseMenu.gameObject.SetActive(true);
        AudioSource.PlayClipAtPoint(click, transform.position);
        Time.timeScale = 0.0f;
    }

    void Update()
    {
        currentTime = displayTimeText.gameObject.GetComponent<Text>();
        currentTime.text = "Time Running: " + Time.timeSinceLevelLoad.ToString("0.0") + " Seconds";
    }

}
