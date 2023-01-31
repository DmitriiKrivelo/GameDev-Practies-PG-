using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i, j;
        print("Таблица умножения");
        for (i = 5; i <= 10; i++)
        {
            for (j = 5; j <= 10; j++)
            {
                print($"{i} x {j} = {i * j}");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
