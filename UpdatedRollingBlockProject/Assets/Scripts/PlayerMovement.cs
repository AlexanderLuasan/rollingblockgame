using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody ThePlayer;
    public float Speed;
    public forwardvector input;
    private Vector3 forceVector;
    private Vector3 leftVector;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        forceVector = input.getForward() * Speed;
        leftVector = input.getLeft() * Speed;

        if (Input.GetKey(KeyCode.W))
        {
            ThePlayer.AddForce(forceVector);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ThePlayer.AddForce(Vector3.zero - forceVector);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ThePlayer.AddForce(leftVector);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ThePlayer.AddForce(Vector3.zero - leftVector);
        }

    }
}
