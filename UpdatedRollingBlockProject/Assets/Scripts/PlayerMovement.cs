using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody ThePlayer;
    public float Speed;
    Vector3 forceVector;
    forceVector = Vector3(0f,0f, Speed);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ThePlayer.AddForce()

    }
}
