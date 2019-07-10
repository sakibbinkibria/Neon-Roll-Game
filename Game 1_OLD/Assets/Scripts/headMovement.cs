
using UnityEngine;

public class headMovement : MonoBehaviour {

    public Vector3 pos;
    Quaternion rot;
    Vector3 playerPos;
    public Transform player;
    private void Start()
    {
        //rot = transform.rotation;
        //rot.x = -.05f;
        //transform.rotation = rot;
        pos = transform.position;
    }
    // Update is called once per frame
    void FixedUpdate() {
        playerPos = player.position;
        pos.x = playerPos.x;// -.38f;
        pos.z = playerPos.z -.68f;
        pos.y = playerPos.y + 1.1f;
        transform.position = pos;
	}
}
