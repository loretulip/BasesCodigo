using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int contar;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >=0)
        {
            while(contar < numero)
            {
                contar++;
                Debug.Log(contar);
            }

            for (int contar = 1; contar < numero; contar++)
            {
                Debug.Log(contar);
            }
        }
        else
        {
            Debug.Log("Tiene que ser un número positivo");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
