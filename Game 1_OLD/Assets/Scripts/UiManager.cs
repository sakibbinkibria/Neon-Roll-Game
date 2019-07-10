using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class UiManager : MonoBehaviour {
    public Text highScore;
    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene 1");
    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
