using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float conversor = Convertir(2, "dolar");
        Debug.Log(conversor);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    float Convertir(float cantidad, string moneda)
    {
        float resultado = 0;
        if (moneda == "dolar")
        {
            float dolarAEuro = cantidad * 1.11f;
        }
        else if (moneda == "euro")
        {
            float euroADolar = cantidad * 0.9f;                        
        }
        return resultado;
    }
}
