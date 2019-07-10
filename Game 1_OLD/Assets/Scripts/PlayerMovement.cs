
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
    public GameManager gm;
    public float forwardForce = 500f;
    public float jumpForce = 500f;
    public float sidewaysForce = 300f;
    public bool isLeftClicked = false;
    public bool isRightClicked = false;
    public float rotVal = 0.06f;
    public GameObject head;
    Quaternion rot;
    private void Start()
    {
        
        rot = head.transform.rotation;
    }

    public void moveLeft()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
    }
    public void moveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
    }
    public void leftClick()
    {
        isLeftClicked = true;
    }
    public void leftClickStop()
    {
        isLeftClicked = false;
        rot.z -= rotVal;
        head.transform.rotation = rot;
    }
    public void rightClick()
    {
        isRightClicked = true;
    }
    public void rightClickStop()
    {
        isRightClicked = false;
        rot.z += rotVal;
        head.transform.rotation = rot;
    }
    public void jump()
    {
        if(rb.transform.position.y<1)
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
    }

    // Update is called once per frame

    void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        //rb.transform.position += Vector3.forward *2* Time.deltaTime;

        if (Input.GetKey("right") || isRightClicked == true)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //rot.y = -180f;
            rot.z = -rotVal;
            head.transform.rotation = rot;
            //isRightClicked = false;
        }
        if (Input.GetKey("left") || isLeftClicked == true)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rot.z = rotVal;
            head.transform.rotation = rot;

            //isLeftClicked = false;
        }
        if (Input.GetKey("escape"))
        {
            gm.MainMenu();
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (rb.position.y < -3)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.useGravity = false;
            enabled = false;
        }
        if (Input.GetKey("space"))
        {
            jump();
        }



    }
}
