using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int num1, num2;
    int num;
    // Start is called before the first frame update
    void Start()
    {

        if (num1 < num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                carac(i);
            }
        }
        else
        {
            for (int i = num2; i <= num1; i++)
            {
                carac(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void carac(int i)
    {
        string signo;
        if (i >= 0)
        {
            signo = "positivo";
        }
        else
        {
            signo = "negativo";
        }
        string paridad;
        if (i % 2 == 0)
        {
            paridad = "par";
        }
        else
        {
            paridad = "impar";
        }
        string resultado = i + " es " + signo + " y " + paridad + ".";
        Debug.Log(resultado);
    }
        

    
}
