using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        bool esPrimo = EsNumeroPrimo(num);
        if (esPrimo)
        {
            Debug.Log(num + " es un número primo.");
        }
        else
        {
            Debug.Log(num + " no es un número primo.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    bool EsNumeroPrimo(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
