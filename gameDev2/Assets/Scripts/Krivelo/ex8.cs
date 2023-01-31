using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex8 : MonoBehaviour
{
    // Start is called before the first frame update
    public int n, m;
    void Start()
    {
        int[,] mass = new int[n,m];
        CreateMass(mass);
        PrintMass(mass);
    }

    int[,] CreateMass(int[,] mass)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mass[i, j] = Random.Range(0, 100);
            }
        }
        return mass;
    }

    void PrintMass(int[,] mass)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                print($"Element with indexes {i}, {j} = {mass[i, j]}");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
