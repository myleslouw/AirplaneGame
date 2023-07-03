using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    private float dive = 0;
    private float rotate;
    private Vector3 planeRotation;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        planeRotation = new Vector3(dive, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Rise();
        } else
        {
            PlaneRotation();
        }
        //transform.Rotate(planeRotation, Space.Self);
    }

    private void Rise()
    {
        if(transform.position.y < 6)
        {
            rb.AddForce(new Vector3(0, 0.1f, 0), ForceMode.Force);
            
            planeRotation.x = dive;
        }
        dive = Mathf.Lerp(0, 30, 0.1f);
        planeRotation.x = dive;
        transform.Rotate(planeRotation, Space.Self);
        print(dive);
    }

    private void PlaneRotation()
    {
        //droops plane
        if (dive >= -20)
        dive = Mathf.Lerp(dive, -20, 0.1f);
        //planeRotation.x = dive;
    }
}
