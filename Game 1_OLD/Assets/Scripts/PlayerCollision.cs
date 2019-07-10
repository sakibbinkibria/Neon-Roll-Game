
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    void OnCollisionEnter(Collision colInfo)
    {
        if(colInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (colInfo.collider.tag == "End")
        {
            
            movement.enabled = false;
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.tag == "End")
        {

            movement.enabled = false;

        }
    }
    }

