using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Prakt2;

namespace Prakt2
{
    class Ex1
    {
        public string stroka;
        public int Acounter = 0;
        public int Bcounter = 0;

        public void Print(string stroka)
        {
            Debug.Log(stroka);
        }

        public void Debug1(string stroka, int Acounter, int Bcounter)
        {
            foreach (char a in stroka)
            {
                if (a == '0')
                {
                    Debug.Log(Bcounter);
                    return;
                }

                if (a == 'a' || a == 'A')
                {
                    Acounter++;
                }

                Bcounter++;

            }
            Debug.Log($"bukv a v stroke - {Acounter} and kol-vo bukv v stroke - {Bcounter}");
        }
    }

    class Ex2
    {
        public const float PI = 3.14f;
        public float circle = 1;
        public float radius = 3;

        public void Debug2(float radius)
        {
            circle = PI * radius * radius;
            Debug.Log(radius);
            Debug.Log($"ploshad kruga = {circle}");
        }
    }

    class Ex3
    {
        public int R, S1, S2 = 20;
        public int a = 4, b = 7;

        public void Debug3(int R, int S1, int S2, int a, int b)
        {
            S1 = a * b;
            if (S1 > S2)
            {
                R = S1 - S2;
                Debug.Log($"ploshad zadannogo - {S2}, ploshad naidennogo - {S1}, raznost ploshadey - {R}");
            }
        }
    }

    class Ex4
    {
        public int i, j;

        public void Debug4(int i, int j)
        {
            Debug.Log("Таблица умножения");
            for (i = 5; i <= 10; i++)
            {
                for (j = 5; j <= 10; j++)
                {
                    Debug.Log($"{i} x {j} = {i * j}");
                }
            }
        }
    }

    class Ex5
    {
        public int n, m, min = 10000, max = -10;

        public void Debug5(int m, int n, int min, int max)
        {
            int[,] nums = new int[n, m];
            int[] nums2 = new int[2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    nums[i, j] = UnityEngine.Random.Range(0, 100);
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

            Debug.Log($"Min value {nums2[0]}");
            Debug.Log($"Max value {nums2[1]}");

            Debug.Log($"Length {nums.Length}");
        }
    }

    class Ex6
    {
        public int n, m;

        public void Debug6(int n, int m)
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
                    nums[i][j] = UnityEngine.Random.Range(0, 2);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    if (nums[i][j] == 1)
                    {
                        Debug.Log($"The element with indexes {j} equals 1 unit");
                    }
                }
            }
        }
    }

    class Ex7
    {
        public int n, m;

        public void Debug7(int n, int m)
        {
            ex7 ex7 = new ex7();
            ex7.Ex1Debug();
            ex7.Ex2Debug();
        }
    }

    class Ex8
    {
        public int m, n;

        public void Debug8(int n, int m)
        {
            ex8 ex8 = new ex8(n, m);
            ex8.Debug71();
        }
    }

    class Ex9
    {
        public int n, m;

        public void Debug9(int n, int m)
        {
            ex9 ex9 = new ex9(n, m);
            ex9.Debug81();
        }
    }

    class Ex10
    {
        public void Debug10()
        {
            int n = 0;
            RandomNumber(ref n);
            Debug.Log($"Generated number - {n}");
        }

        public int RandomNumber(ref int n)
        {
            n = UnityEngine.Random.Range(0, 500);
            return n;
        }
    }

    class Ex11
    {
        public int n = 3;

        public void Debug11()
        {
            DayOfWeek(in n);
        }

        public void DayOfWeek(in int n)
        {
            switch (n)
            {
                case 1:
                    Debug.Log("Today is monday");
                    break;
                case 2:
                    Debug.Log("Today is tuesday");
                    break;
                case 3:
                    Debug.Log("Today is wednesday");
                    break;
                case 4:
                    Debug.Log("Today is thursday");
                    break;
                case 5:
                    Debug.Log("Today is friday");
                    break;
                case 6:
                    Debug.Log("Today is saturday");
                    break;
                case 7:
                    Debug.Log("Today is SUNDAY");
                    break;
                default:
                    Debug.Log("Something went wrong...");
                    break;
            }
        }
    }
}
namespace Prakt4
{
    public class Ex13 : MonoBehaviour
    {
        private ex7 Ex7;
        private ex8 Ex8;
        
        private void Start()
        {
            Main();
        }

        void Main()
        {
            //Debug.Log("Pr1ex1");
            //Ex1 ex1 = new Ex1();
            //ex1.stroka = "Negry vse v adidasah grebanye blyat0, negry vse v adidasah budem ih ebat";
            //ex1.Print(ex1.stroka);
            //ex1.Debug1(ex1.stroka, ex1.Acounter, ex1.Bcounter);

            //Debug.Log("Pr1ex2");
            //Ex2 ex2 = new Ex2();
            //ex2.Debug2(3);

            //Debug.Log("Pr1ex3");
            //Ex3 ex3 = new Ex3();
            //ex3.Debug3(ex3.R, ex3.S1, ex3.S2, ex3.a, ex3.b);

            //Debug.Log("Pr1ex4");
            //Ex4 ex4 = new Ex4();
            //ex4.Debug4(ex4.i, ex4.j);

            //Debug.Log("Pr2ex1");
            //Ex5 ex5 = new Ex5();
            //ex5.Debug5(5, 5, ex5.min, ex5.max);

            //Debug.Log("Pr2ex2");
            //Ex6 ex6 = new Ex6();
            //ex6.Debug6(2, 4);

            //Debug.Log("Pr2ex3");
            //Ex7 ex7 = new Ex7();
            //ex7.Debug7(3, 4);

            //Debug.Log("Pr2ex4");
            //Ex8 ex8 = new Ex8();
            //ex8.Debug8(4, 4);

            //Debug.Log("Pr2ex5");
            //Ex9 ex9 = new Ex9();
            //ex9.Debug9(4, 4);

            //Debug.Log("Pr2ex6");
            //Ex10 ex10 = new Ex10();
            //ex10.Debug10();

            Debug.Log("Pr2ex7");
            Ex11 ex11 = new Ex11();
            ex11.Debug11();
        }
    }   
}