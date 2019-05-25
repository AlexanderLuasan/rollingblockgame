using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionWithGround : MonoBehaviour
{

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ground")
        {
            Debug.Log("hit Ground");
        }


    }
}
