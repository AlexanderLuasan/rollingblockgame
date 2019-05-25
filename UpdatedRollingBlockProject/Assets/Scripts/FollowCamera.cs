using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Vector3 cameraOffset;
    private Transform ThingCameraIsFollowing;
    public GameObject player;
    public forwardvector playersDirection;
    // Start is called before the first frame update
    void Start()
    {
        ThingCameraIsFollowing = player.GetComponent<Transform>();
        playersDirection = player.GetComponent<forwardvector>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 f = playersDirection.getforward();
        f = f * -5;
        transform.position = ThingCameraIsFollowing.position + f + Vector3.up;
        transform.LookAt(ThingCameraIsFollowing);
    }
}
