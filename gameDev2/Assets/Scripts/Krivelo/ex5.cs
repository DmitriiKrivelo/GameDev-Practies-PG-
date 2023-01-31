using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public int n, m;
    // Start is called before the first frame update
    void Start()
    {
        int[,] nums = new int[n, m];
        int[] nums2 = new int[2];
        int min = 10000;
        int max = -10;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                nums[i, j] = Random.Range(0, 100);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (nums[i, j] < min)
                    min = nums[i, j];
                if (nums[i, j] > max)
                    max = nums[i, j];
            }
        }

        nums2[0] = min;
        nums2[1] = max;

        print($"Min value {nums2[0]}");
        print($"Max value {nums2[1]}");

        print($"Length {nums.Length}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
