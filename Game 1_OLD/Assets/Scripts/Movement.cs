
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 300f;

    public void moveLeft()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void moveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
