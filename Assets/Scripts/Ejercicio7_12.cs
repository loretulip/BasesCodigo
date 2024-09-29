using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int num1, num2;
    // Start is called before the first frame update
    void Start()
    {

        int suma = SumarTodosLosNumeros(num1, num2);
        Debug.Log("La suma de todos los números entre " + num1 + " y " + num2 + " es: " + suma);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    int SumarTodosLosNumeros(int a, int b)
    {
        int sumaTotal = 0; 
        if (a > b)
        {
            int temp = a; 
            a = b;
            b = temp;
        }
        for (int i = a; i <= b; i++)
        {
            sumaTotal += i;
        }
        return sumaTotal;
    }
}
