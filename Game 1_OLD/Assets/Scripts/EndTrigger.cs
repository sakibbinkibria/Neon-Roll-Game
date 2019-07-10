
using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public GameManager gameManager;
    public Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        //rb.AddForce(0, 0, -1000f);
       
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        gameManager.LevelComplete();
    }
}
