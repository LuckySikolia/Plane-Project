using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePropeller : MonoBehaviour
{
    private float propellerRotationSpeed = 150.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform the propeller along the Z axis
        transform.Rotate(Vector3.forward * Time.deltaTime * propellerRotationSpeed);
    }
}
