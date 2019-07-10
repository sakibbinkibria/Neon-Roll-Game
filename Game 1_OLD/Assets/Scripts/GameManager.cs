using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameIsOver = false;
    public GameObject levelCompleteUI, btnL, btnR, gameOverUI;

    public void LevelComplete()
    {
        btnL.SetActive(false);
        btnR.SetActive(false);
        levelCompleteUI.SetActive(true);
        
    }

	public void EndGame()
    {
        if(gameIsOver == false)
        {
            gameIsOver = true;
            gameOverUI.SetActive(true);
           
            //Restart();
;        }
        
    }
    public void Restart()
    {
        btnL.SetActive(true);
        btnR.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
            Application.Quit();
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Welcome Scene");
    }
}
