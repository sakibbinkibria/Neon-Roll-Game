using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	// Update is called once per frame
	void Update () {
        int score;
        score = (int)(player.position.z / 5.0);
        scoreText.text = score.ToString("0");
        if (score > PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
	}
}
