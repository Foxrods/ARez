using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    float yRotation = 5.0f;
    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(Vector3.forward * Time.deltaTime*35, Space.World);
        
    }
}
