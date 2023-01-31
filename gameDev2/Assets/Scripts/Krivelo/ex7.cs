using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

public class ex7 : MonoBehaviour
{
    // Start is called before the first frame update
    public int n, m;
    void Start()
    {
        Ex1Debug();
        Ex2Debug();
    }

    void Ex1Debug()
    {
        int[,] nums = new int[n, m];
        int[] result = null;
        result = Ex1(nums);
        for (int i = 0; i < result.Length; i++)
        {
            print(result[i]);
        }
    }

    void Ex2Debug()
    {
        List<int> result1 = Ex2();
        for (int j = 0; j < result1.Count; j++)
        {
            print($"The element with indexes {result1[j]} equals 1 unit");
        }
    }
    
    int[] Ex1(int[,] nums)
    {
        int[] nums2 = new int[3];
        int min = 10000, max = -1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                nums[i, j] = Random.Range(0, 100);
            }
        }

        nums2[0] = Min(nums, min);
        nums2[1] = Max(nums, max);
        nums2[2] = LengthMass(nums);
        return nums2;
    }    
    int Min(int[,] nums, int min)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (nums[i, j] < min)
                        min = nums[i, j];
                }
            }
            return min;
        }
        
        int Max(int[,] nums, int max)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (nums[i, j] > max)
                        max = nums[i, j];
                }
            }
            return max;
        }

        int LengthMass(int[,] nums) => nums.Length;
        
        
        
    List<int> Ex2()
    {
        int[][] nums = new int[n][];
        List<int> result = new List<int>();
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
                    result.Add(j + i * nums[i].Length);
                }
            }
        }
        return result;
    }
        



    // Update is called once per frame
    void Update()
    {
        
    }
}
