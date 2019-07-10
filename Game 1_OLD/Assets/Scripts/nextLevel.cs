using UnityEngine.SceneManagement;
using UnityEngine;

public class nextLevel : MonoBehaviour {
    public void LoadNextLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void FixedUpdate()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
