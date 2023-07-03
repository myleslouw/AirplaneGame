using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMover : MonoBehaviour
{
    public Transform current;

    // Start is called before the first frame update
    void Start()
    {
        current = transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0, CONSTANTS.MOVESPEED);
    }
}
