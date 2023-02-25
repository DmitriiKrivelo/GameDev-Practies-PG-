using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hall hall = new Hall(7, 8, 15, 1, 1.5f, 100);
        hall.allSeats = hall.Fill(hall.weight, hall.height);
        int freeSeats = hall.FreeSeats();
        Debug.Log(freeSeats);
        //hall.Print(hall.allSeats);
        hall.fullPrice = hall.FullPrice();
        Debug.Log(hall.fullPrice);
    }
}

public class Hall
{
    public int[,] allSeats;
    public int weight;
    public int height;
    public int count;
    public float koefN;
    public float koefM;
    public int seatPrice;
    public float fullPrice;

    public int[,] Fill(int weight, int height)
    {
        int[,] mas = new int[weight, height];

        int count = this.count;
        
        for (int i = 0; i < weight; i++)
        {
            for (int j = 0; j < height; j++)
            {
                mas[i, j] = 0;
            }
        }

        while(count > 0)
        {
            int i = UnityEngine.Random.Range(0, weight);
            int j = UnityEngine.Random.Range(0, height);

            if (mas[i, j] == 0)
            {
                mas[i, j] = 1;
                count--;
            } 
        }

        return mas;
    }

    public int FreeSeats()
    {
        int freeSeats = weight * height - count;
        return freeSeats;
    }

    //public void Print(int[,] allSeats)
    //{
    //    for (int i = 0; i < weight; i++)
    //    {
    //        for (int j = 0; j < height; j++)
    //        {
    //            Debug.Log(allSeats[i, j]);
    //        }
    //    }
    //}

    public Hall(int weight, int height, int count, float koefN, float koefM, int seatPrice)
    {
        this.weight = weight;
        this.height = height;
        this.count = count;
        this.koefN = koefN;
        this.koefM = koefM;
        this.seatPrice = seatPrice;
        fullPrice = 0;
    }

    public float FullPrice()
    {
        float sektor1 = weight * height * 0.2f;
        Convert.ToInt32(sektor1);
        float sektor2 = weight * height * 0.85f;
        Convert.ToInt32(sektor2);
        float sektor3 = weight * height - sektor1 - sektor2;
        Convert.ToInt32(sektor3);

        for (int i = 0; i < weight; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (allSeats[i, j] == 1)
                {
                    if((i+1)*(j+1) <= sektor1 || (i+1)*(j+1) >= sektor2)
                    {
                        fullPrice += koefN * seatPrice;
                        //Debug.Log(koefN * seatPrice);
                    }
                    else
                    {
                        fullPrice += koefM * seatPrice;
                        //Debug.Log(koefM * seatPrice);
                    }
                }

                //Debug.Log(fullPrice);
            }
        }

        return fullPrice;
    }
}
