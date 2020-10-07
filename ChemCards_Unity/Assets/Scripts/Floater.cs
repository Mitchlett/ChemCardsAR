using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    // indepented time variable
    private double time;
    private Vector3 y = new Vector3();
    private float bounce = (float)0.0005;     //the larger this value is, the higher it bounces
    
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += 0.025;       //the larger this value is, the faster it bounces
        y.Set(0, (float)System.Math.Sin(time) * bounce, 0);
        transform.Translate(y, Space.Self);

    }
}