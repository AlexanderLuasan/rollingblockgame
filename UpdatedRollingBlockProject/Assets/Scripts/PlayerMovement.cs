using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody ThePlayer;
    public float Speed;
    public string moveButton;
    Vector3 forceVector;


    // Start is called before the first frame update
    void Start()
    {
        forceVector = new Vector3(0f, 0f, Speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(moveButton))
        {
            ThePlayer.AddForce(forceVector)
        }

    }
}
