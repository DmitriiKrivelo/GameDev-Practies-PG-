using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string stroka = "Negry vse v adidasah grebanye blyat0, negry vse v adidasah budem ih ebat";
        int Acounter = 0;
        int Bcounter = 0;
        print(stroka);

        foreach(char a in stroka)
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
