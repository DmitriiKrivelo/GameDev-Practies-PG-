using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float PI = 3.14f;
        float circle, radius = 3;

        circle = PI * radius * radius;
        print($"ploshad kruga = {circle}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
