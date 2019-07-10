using UnityEngine;

public class lightFollow : MonoBehaviour {

    public Vector3 pos;
    Vector3 playerPos;
    public Transform player;
    private void Start()
    {
        pos = transform.position;
    }

    void FixedUpdate()
    {
        playerPos = player.position;
        pos.z = playerPos.z + 5f;
        transform.position = pos;
    }
}
