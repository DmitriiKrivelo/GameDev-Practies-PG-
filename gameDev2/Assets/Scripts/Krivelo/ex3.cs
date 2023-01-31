using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int R, S1, S2 = 20;
        int a = 4, b = 7;
        S1 = a * b;
        if (S1 > S2)
        {
            R = S1 - S2;
            Debug.Log($"ploshad zadannogo - {S2}, ploshad naidennogo - {S1}, raznost ploshadey - {R}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
