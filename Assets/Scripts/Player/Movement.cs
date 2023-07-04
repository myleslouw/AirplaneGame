using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    private float rotate;
    private Vector3 planeRotation;
    private float planeTilt;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        planeRotation = new Vector3(20, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Rise();
        } else
        {
            PlaneDroop();
        }
        //transform.Rotate(planeRotation, Space.Self);
    }

    private void Rise()
    {
        //move up

        print(rb.velocity);

        if(transform.position.y < 6)
        {
            rb.AddForce(new Vector3(0, 0.1f, 0), ForceMode.Force);

            if (transform.rotation.x > -0.3f)
            {
                transform.Rotate(-80 * Time.deltaTime, 0, 0);
            }
        }
       
    }

    private void PlaneDroop()
    {
        //droops plane
        if(transform.rotation.x < 0.5f)
        {
            transform.Rotate(60 * Time.deltaTime, 0, 0);

        }
    }
}
