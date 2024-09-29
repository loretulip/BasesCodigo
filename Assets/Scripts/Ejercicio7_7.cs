using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int num1, num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 != num2)
        {
            int menor, mayor;
            
            if(num1<num2)
            {
                menor = num1;
                mayor = num2;
            }
            else
            {
                menor = num2;
                mayor = num1;
            }

            int contador = menor;
            while(contador <=mayor)
            {
                Debug.Log(contador);
                contador++;
            }           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
