using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody ThePlayer;
    public float Speed;
    public Vector3 forwardVector;
    private Vector3 forceVector;
    private Vector3 rightVector;

    // Start is called before the first frame update
    void Start()
    {
        forceVector = Vector3.Normalize(forwardVector) * Speed;
        Vector3 upVector = new Vector3(0f, 1f, 0);
        rightVector = Vector3.Cross(forceVector, upVector);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ThePlayer.AddForce(forceVector);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ThePlayer.AddForce(forceVector * -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ThePlayer.AddForce(-1 * rightVector);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ThePlayer.AddForce(rightVector);
        }

    }
}
