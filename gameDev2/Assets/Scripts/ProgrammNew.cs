using System;
using UnityEngine;

public class ProgrammNew : MonoBehaviour
{
    public void Start()
    {
        for (int i = 5; i <= 10; i++)
        {
            string result = "";

            for (int j = 5; j <= 10; j++)
            {
                result += $"\n {i}x{j}={i * j}";
            }

            print(result);
        }
    }
}
