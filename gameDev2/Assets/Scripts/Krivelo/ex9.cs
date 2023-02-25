using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    public int n, m;
    public void Start()
    {
        Debug81();
    }

    public ex9(int n, int m)
    {
        this.n = n;
        this.m = m;
    }

    public void Debug81()
    {
        int[][] mass = new int[n][];
        for (int i = 0; i < n; i++)
        {
            mass[i] = new int[m];
        }
        CreateMass(mass, m);
    }

    int[][] CreateMass(int[][] mass, int m, int n = 2)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mass[i][j] = Random.Range(0, 100);
            }
        }
        return mass;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
