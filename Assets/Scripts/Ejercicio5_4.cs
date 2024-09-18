using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int num1, num2;
    float divisor,resultado;
    // Start is called before the first frame update
    void Start()
    {
        divisor = num1 % num2;
        if(divisor!=0)
        {
            resultado = num1 / num2;
            Debug.Log("El resultado es " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
