using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 0;
        RandomNumber(ref n);
        print($"Generated number - {n}");
    }

    int RandomNumber(ref int n)
    {
        n = Random.Range(0, 500);
        return n;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
