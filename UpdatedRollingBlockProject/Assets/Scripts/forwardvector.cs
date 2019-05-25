using UnityEngine;
using System;

public class forwardvector : MonoBehaviour
{
    public Vector3 forward;
    private double sin = Math.Sin(.5);
    private double cos = Math.Cos(.5);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("q"))
        {
            float nx = (float)(forward.x * cos - forward.z * sin);
            float nz = (float)(forward.x * sin + forward.z * cos);
            float ny = (float)forward.y;
            forward.Set(nx, ny, nz);
        }
    }
}
