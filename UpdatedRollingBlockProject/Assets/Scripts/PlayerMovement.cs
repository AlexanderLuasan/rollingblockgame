using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody ThePlayer;
    public float Speed;
    public Vector3 forwardVector;
    private Vector3 forceVector;

    // Start is called before the first frame update
    void Start()
    {
        forceVector = Vector3.Normalize(forwardVector) * Speed;
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
            ThePlayer.AddForce(forceVector);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ThePlayer.AddForce(-1 * forceVector);
        }

    }
}
