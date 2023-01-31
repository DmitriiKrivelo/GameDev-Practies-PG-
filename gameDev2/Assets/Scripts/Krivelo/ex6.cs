using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex6 : MonoBehaviour
{
    public int n, m;
    // Start is called before the first frame update
    void Start()
    {
        int[][] nums = new int[n][];
        for (int i = 0; i < n; i++)
        {
            nums[i] = new int[m];
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                nums[i][j] = Random.Range(0, 2);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                if (nums[i][j] == 1)
                {
                    print($"The element with indexes {j} equals 1 unit");
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
