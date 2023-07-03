using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONSTANTS : MonoBehaviour
{
    public static float HEIGHT = -5f;
    public static float MOVING = 0f;
    public static float MOVESPEED;

    private void Awake()
    {
        MOVESPEED = -0.1f * Time.deltaTime;
    }
    private void Update()
    {
        //MOVING -= 0.1f * Time.deltaTime;
        //print(MOVING);
    }
}
