using UnityEngine;
using System;

public class forwardvector : MonoBehaviour
{
    public Vector3 forward;
    private double sinpos = Math.Sin(.1);
    private double cosneg = Math.Cos(-.1);
    private double sinneg = Math.Sin(-.1);
    private double cospos = Math.Cos(.1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("q"))
        {
            float nx = (float)(forward.x * cosneg - forward.z * sinneg);
            float nz = (float)(forward.x * sinneg + forward.z * cosneg);
            float ny = (float)forward.y;
            forward.Set(nx, ny, nz);
        }

        if (Input.GetKey("e"))
        {
            float nx = (float)(forward.x * cospos - forward.z * sinpos);
            float nz = (float)(forward.x * sinpos + forward.z * cospos);
            float ny = (float)forward.y;
            forward.Set(nx, ny, nz);
        }

    }
}
