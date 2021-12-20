using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroCamara : MonoBehaviour
{

    public float verticalSpeed = 1.0F;

    void Update()
    {   
        float v = -1 * verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, 0, 0);
    }
}
