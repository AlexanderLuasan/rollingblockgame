using UnityEngine;
using System;

public class forwardvector : MonoBehaviour
{
    public Vector3 forward;
    private Vector3 left;
    private double sinpos = Math.Sin(.01);
    private double cosneg = Math.Cos(-.01);
    private double sinneg = Math.Sin(-.01);
    private double cospos = Math.Cos(.01);
    private Vector3 upVector = new Vector3(0f, 1f, 0);



    // Start is called before the first frame update
    void Start()
    {
        left = Vector3.Cross(forward, upVector);
    }

    public Vector3 getLeft()
    {
        return left;
    }

    public Vector3 getForward()
    {
        return forward;
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

            float nxl = (float)(left.x * cosneg - left.z * sinneg);
            float nzl = (float)(left.x * sinneg + left.z * cosneg);
            float nyl = (float)left.y;
            left.Set(nxl, nyl, nzl);

        }

        if (Input.GetKey("e"))
        {
            float nx = (float)(forward.x * cospos - forward.z * sinpos);
            float nz = (float)(forward.x * sinpos + forward.z * cospos);
            float ny = (float)forward.y;
            forward.Set(nx, ny, nz);

            float nxl = (float)(left.x * cospos - left.z * sinpos);
            float nzl = (float)(left.x * sinpos + left.z * cospos);
            float nyl = (float)left.y;
            left.Set(nxl, nyl, nzl);
        }

    }
}
