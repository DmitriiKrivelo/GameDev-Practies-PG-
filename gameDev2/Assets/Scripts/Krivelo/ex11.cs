using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex11 : MonoBehaviour
{
    // Start is called before the first frame update
    public int n;
    void Start()
    {
        DayOfWeek(in n);
    }

    void DayOfWeek(in int n)
    {
        switch (n)
        {
            case 1:
                print("Today is monday");
                break;
            case 2:
                print("Today is tuesday");
                break;
            case 3:
                print("Today is wednesday");
                break;
            case 4:
                print("Today is thursday");
                break;
            case 5:
                print("Today is friday");
                break;
            case 6:
                print("Today is saturday");
                break;
            case 7:
                print("Today is SUNDAY");
                break;
            default:
                print("Something went wrong...");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
