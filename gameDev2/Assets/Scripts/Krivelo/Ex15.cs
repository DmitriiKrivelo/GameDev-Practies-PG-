using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex15 : MonoBehaviour
{
    private void Start()
    {
        Point point1 = new Point { x = 2, y = 1, z = 1};
        Point point2 = new Point { x = 4, y = 2, z = 3};

        point1.Print(point1.x, point1.y, point1.z);
        point2.Print(point2.x, point2.y, point2.z);
        point1.GetDistance(point1, point2);
        point2.Displacement(point2.x, point2.y, point2.z);
        point2.Print(point2.x, point2.y, point2.z);
    }
}

struct Point
{
    public float x;
    public float y;
    public float z;

    public void GetDistance(Point point1, Point point2)
    {
        float a = point2.x - point1.x;
        float b = point2.y - point1.y;
        float c = point2.z - point1.z;
        float line = Mathf.Sqrt(a * a + b * b + c * c);
        Debug.Log(line);
    }

    public void Displacement(float x, float y, float z)
    {
        this.x += UnityEngine.Random.Range(-5, 6);
        this.y += UnityEngine.Random.Range(-5, 6);
        this.z += UnityEngine.Random.Range(-5, 6);
    }
    
    public void Null(float x, float y, float z)
    {
        this.x = 0;
        this.y = 0;
        this.z = 0;
    }

    public void Print(float x, float y, float z)
    {
        Debug.Log($"x {x} y {y} z {z}");
    }
}

