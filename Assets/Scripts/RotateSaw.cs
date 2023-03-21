using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSaw : MonoBehaviour
{

    public float rotationSpeed = 10.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }
}
