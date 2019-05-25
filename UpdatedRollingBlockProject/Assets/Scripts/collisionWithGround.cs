using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionWithGround : MonoBehaviour
{
    public HealthDisplay HPdisp;
    private bool hasHitGround = false;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (hasHitGround && collisionInfo.collider.tag == "ground")
        {
            HPdisp.addToScore(1);
            hasHitGround = true;
# Destroy(self)
        }
    }
}
