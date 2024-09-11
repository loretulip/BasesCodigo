using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 3.3f;

    float calculo1;
    float calculo2;
    float calculo3;
    float calculo4;
    float calculo5;

    // Start is called before the first frame update
    void Start()
    {
        calculo1 = vidas * exp;
        calculo2 = vidas / exp;
        calculo3 = vidas % exp;
        calculo3 = vidas * 2;
        calculo3 = exp * 3;

        Debug.Log(calculo1);
        Debug.Log(calculo2);
        Debug.Log(calculo3);
        Debug.Log(calculo4);
        Debug.Log(calculo5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
