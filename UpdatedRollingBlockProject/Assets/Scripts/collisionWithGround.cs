using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionWithGround : MonoBehaviour
{
    private HealthDisplay HPdisp;
    private bool hasHitGround = false;

    private void Start()
    {
        HPdisp = FindObjectOfType<Canvas>().GetComponent<HealthDisplay>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (!hasHitGround && collisionInfo.collider.tag == "ground")
        {
            HPdisp.addToScore(1);
            hasHitGround = true;
        }
    }
}
