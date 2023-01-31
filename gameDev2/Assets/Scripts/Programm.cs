using UnityEngine;

public class Programm : MonoBehaviour
{
    void Start()
    {
        //суффикс f
        float decimalNumber = 3.14f;

        //суффикс L
        long Number = 3L;

        Debug.Log("Hello");
        print("Hello print");

        Debug.Log($"{decimalNumber}, {Number}");
    }

    void Update()
    {
        
    }
}
