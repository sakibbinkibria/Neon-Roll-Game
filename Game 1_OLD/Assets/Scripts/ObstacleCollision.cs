
using UnityEngine;

public class ObstacleCollision : MonoBehaviour {

    public AudioManager am;

    void OnCollisionEnter(Collision colInfo)
    {
        if (colInfo.collider.tag == "Player")
        {
            am.PlayCollisionAudio();
            Debug.Log("sound");
        }
    }
}
