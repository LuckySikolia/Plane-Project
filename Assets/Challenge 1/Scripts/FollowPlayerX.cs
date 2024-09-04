using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    
    private Vector3 offset = new Vector3(14.4f, 1.9f, 0.2f);
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //apply camera position
        transform.position = plane.transform.position + offset;

        
    }
}
