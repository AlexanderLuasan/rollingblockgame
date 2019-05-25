using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Vector3 cameraOffset;
    private Transform ThingCameraIsFollowing;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        ThingCameraIsFollowing = player.GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = ThingCameraIsFollowing.position + cameraOffset;
    }
}
