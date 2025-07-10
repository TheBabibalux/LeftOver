using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAutoPivot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform camTransform = Camera.main.transform;
        Vector3 camPosModified = new Vector3(camTransform.position.x, transform.position.y, camTransform.position.z);

        transform.LookAt(camPosModified);
    }
}
